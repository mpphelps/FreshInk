using System;

namespace FreshInk
{
    internal class PrinterManager
    {
        private static PrinterManager instance;
        private static readonly object lockObject = new object();

        private IPrintTestConfigParser _parser;
        private IPrintJob _job;
        private PrintTestConfig _config;

        private PrinterManager()
        {
            _parser = new JsonPrintTestConfigParser();
            _config = _parser.ParsePrintTestConfigs();
        }

        public static PrinterManager Instance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance = new PrinterManager();
                }
            }
            return instance;
        }

        public void RunPrintTests()
        {
            CreatePrintJob();
            LoadPrintDocument();

            if (DateTime.Now > _config.TargetDate)
            {
                PrintTests();
            }

            ClosePrintDocument();

            _parser.SerializePrintTestConfigs(_config);

        }

        private void CreatePrintJob()
        {
            try
            {
                _job = GetDocumentJob(_config.TestDocument);
            }
            catch (Exception ex)
            {
                FileLogger.LogError("Failed to get document job, will use default test.", ex);
                _job = new PrintDocumentJob();
                _config.TestDocument = "Default";
            }
        }

        private IPrintJob GetDocumentJob(string documentName)
        {
            if (documentName == "Default")
            {
                return new PrintDocumentJob();
            }
            else if (documentName.EndsWith(".docx"))
            {
                return new WordDocumentJob();
            }
            else
            {
                throw new Exception("Document job specified is invalid");
            }
        }

        private void LoadPrintDocument()
        {
            try
            {
                _job.LoadDocument(_config.TestDocument);
            }
            catch (Exception ex)
            {
                FileLogger.LogError("Failed to load test document, will use default test.", ex);
                _job = new PrintDocumentJob();
                _config.TestDocument = "Default";
                _job.LoadDocument(_config.TestDocument);
            }
        }

        private void PrintTests()
        {
            foreach (var printer in _config.PrinterNames)
            {
                FileLogger.LogInformation($"Printing {_config.TestDocument} test run for printer: {printer}");
                try
                {
                    _job.PrintDocumentTo(printer);
                }
                catch (Exception ex)
                {
                    FileLogger.LogError($"Failed to print test for printer {printer}.  Check printer name exists or spelling.", ex);
                }

                _config.TargetDate = _config.TargetDate.AddDays(_config.TestInterval);
            }
        }

        private void ClosePrintDocument()
        {
            try
            {
                _job.CloseDocument();
            }
            catch (Exception ex)
            {
                FileLogger.LogError("error closing print job", ex);
            }
        }
    }
}
