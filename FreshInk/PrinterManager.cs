using System;

namespace FreshInk
{
    internal class PrinterManager
    {
        private static PrinterManager instance;
        private static readonly object lockObject = new object();

        private IPrintTestConfigParser _parser;
        private IPrintJob _job;

        private PrinterManager(IPrintTestConfigParser parser, IPrintJob job)
        {
            _parser = parser;
            _job = job;
        }

        public static PrinterManager Instance(IPrintTestConfigParser parser, IPrintJob job)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance = new PrinterManager(parser, job);
                }
            }
            return instance;
        }

        public void RunPrintTests()
        {

            PrintTestConfigs configs = _parser.ParsePrintTestConfigs();
            

            foreach (var config in configs.Configs)
            {
                if (DateTime.Now > config.TargetDate)
                {
                    _job.LoadDocument();
                    _job.PrintDocumentTo(config.PrinterName);
                    config.TargetDate = config.TargetDate.AddDays(14);
                    _job.CloseDocument();
                }
            }

            _parser.SerializePrintTestConfigs(configs);
            
        }
    }
}
