﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using FreshInkUtilities;
using Microsoft.Office.Interop.Word;

namespace FreshInk
{
    internal class WordDocumentJob : IPrintJob
    {
        private Application _wordApp;
        private Document _wordDoc;

        public WordDocumentJob()
        {
            try
            {
                _wordApp = new Application();
            }
            catch (COMException ex)
            {
                FileLogger.LogError("Error creating Microsoft Word application, is Word installed?");
                throw ex;
            }
        }

        public void LoadDocument(string fileName)
        {
            string filePath = Path.Combine(RegistryManager.GetConfigPath(), fileName);
            if (File.Exists(filePath))
            {
                _wordDoc = _wordApp.Documents.Open(filePath, ReadOnly: true);
            }
            else
            {
                throw new Exception("Test file specified does not exist.");
            }
        }

        public void PrintDocumentTo(string printerName)
        {
            try
            {
                _wordApp.ActivePrinter = printerName;
                _wordDoc.PrintOut(Background: false, PrintToFile: false);
            }
            catch (COMException ex)
            {
                FileLogger.LogError("The is an COM error printing to the document, did Word get closed?", ex);
            }
            catch (Exception ex)
            {
                FileLogger.LogError("Exception occurred while printing.", ex);
            }
        }

        public void CloseDocument()
        {
            _wordDoc.Close();
            _wordApp.Quit();
        }
    }
}
