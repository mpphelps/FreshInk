using System;

namespace FreshInk
{
    internal class PrinterManager
    {
        private static PrinterManager instance;
        private static readonly object lockObject = new object();

        private IPrintTestConfigParser _parser;
        private IPrintJob _job;

        private PrinterManager()
        {
            _parser = new JsonPrintTestConfigParser();
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

            PrintTestConfig config = _parser.ParsePrintTestConfigs();

            try
            {
                _job = GetDocumentJob(config.TestDocument);
            }
            catch
            {
                _job = new PrintDocumentJob();
                config.TestDocument = "Default";
            }

            _job.LoadDocument(config.TestDocument);
            if (DateTime.Now > config.TargetDate)
            {
                foreach (var printer in config.PrinterNames)
                {
                    FileLogger.LogInformation($"Printing {config.TestDocument} test run for printer: {printer}");
                    _job.PrintDocumentTo(printer);
                    config.TargetDate = config.TargetDate.AddDays(config.TestInterval);
                }
            }
            _job.CloseDocument();

            _parser.SerializePrintTestConfigs(config);
            
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
                string message = "Document job specified is invalid, will use default.";
                FileLogger.LogError(message);
                throw new Exception(message);
            }
        }
    }
}
