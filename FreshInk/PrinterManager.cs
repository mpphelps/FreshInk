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

            PrintTestConfigs configs = _parser.ParsePrintTestConfigs();

            _job = GetDocumentJob(configs.TestDocument);
            if (_job is PrintDocumentJob)
                configs.TestDocument = "Default";

            _job.LoadDocument(configs.TestDocument);
            foreach (var config in configs.Configs)
            {
                if (DateTime.Now > config.TargetDate)
                {
                    
                    _job.PrintDocumentTo(config.PrinterName);
                    config.TargetDate = config.TargetDate.AddDays(configs.TestInterval);
                    
                }
            }
            _job.CloseDocument();

            _parser.SerializePrintTestConfigs(configs);
            
        }

        private IPrintJob GetDocumentJob(string documentName)
        {
            if (documentName == "Default")
            {
                return new PrintDocumentJob();
            }
            if (documentName.EndsWith(".docx"))
            {
                return new WordDocumentJob();
            }
            return new PrintDocumentJob();

        }
    }
}
