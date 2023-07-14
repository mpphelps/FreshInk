using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace FreshInk
{
    internal class WordDocumentJob : IPrintJob
    {
        Application wordApp;
        Document wordDoc;

        public WordDocumentJob()
        {
            try
            {
                wordApp = new Application();
            }
            catch (COMException ex)
            {
                throw new Exception("Error create Microsoft Word application, is Word installed?", ex);
            }
            
        }

        public void LoadDocument(string fileName)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), fileName);
            if (File.Exists(filePath))
            {
                wordDoc = wordApp.Documents.Open(filePath, ReadOnly: true);
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
                wordApp.ActivePrinter = printerName;
                wordDoc.PrintOut(Background: false, PrintToFile: false);
            }
            catch (COMException ex)
            {
                throw new Exception("The is an COM error printing to the document, did Word get closed?", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Exception occurred while printing.", ex);
            }
        }

        public void CloseDocument()
        {
            wordDoc.Close();
            wordApp.Quit();
        }
    }
}
