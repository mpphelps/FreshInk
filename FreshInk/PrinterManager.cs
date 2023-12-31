﻿using Microsoft.Office.Interop.Word;
using FreshInkUtilities;
using System;
using System.Collections.Generic;
using System.Printing;
using System.Windows.Forms;

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
            GetConfigs();
            RemoveDuplicatePrinters();
            CreatePrintJob();
            LoadPrintDocument();
            PrintTests();
            ClosePrintDocument();
        }

        private void GetConfigs()
        {
            _config = _parser.GetConfigs();
        }

        private void RemoveDuplicatePrinters()
        {
            var printerSet = new HashSet<string>();
            var removeSet = new HashSet<string>();
            foreach(var printer in _config.PrinterNames)
            {
                if (!printerSet.Contains(printer)) 
                { 
                    printerSet.Add(printer); 
                }
                else 
                {
                    removeSet.Add(printer);
                }
            }

            foreach(var printer in removeSet)
            {
                _config.PrinterNames.Remove(printer);
                _parser.SaveConfigs(_config);
                FileLogger.LogInformation($"{printer} is listed twice, removing from config");
            }
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
                _parser.SaveConfigs(_config);
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
                // If for some reason a bad test document is specified, this will resave with the default.
                _config.TestDocument = "Default";                
                _parser.SaveConfigs(_config);
                _job.LoadDocument(_config.TestDocument);
            }
        }

        private void PrintTests()
        {
            var invalidPrinters = new List<string>();
            foreach (var printer in _config.PrinterNames)
            {
                FileLogger.LogInformation($"Printing {_config.TestDocument} test run for printer: '{printer}'");
                try
                {
                    _job.PrintDocumentTo(printer);
                    if (DidPrintFail(printer, out PrintQueueStatus status))
                    {
                        MessageBox.Show($"Error printing test job.\nStatus of '{printer}': {status}");
                        FileLogger.LogError($"Status of {printer}: {status}");
                    }
                    
                }
                catch (Exception ex)
                {
                    // If for some reason an invalid printer is in the list, remove it and resave config
                    invalidPrinters.Add(printer);
                    FileLogger.LogError($"Failed to print test for printer '{printer}'.  Check printer name exists or spelling.  Removing '{printer}' from coniguration.", ex);
                }
            }
            foreach(var printer in invalidPrinters)
            {
                _config.PrinterNames.Remove(printer);
                _parser.SaveConfigs(_config);
            }
        }

        private bool DidPrintFail(string printer, out PrintQueueStatus printStatus)
        {
            var printServer = new LocalPrintServer();
            var printQueue = printServer.GetPrintQueue(printer);
            printStatus = printQueue.QueueStatus;
            return printStatus != PrintQueueStatus.None;
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
