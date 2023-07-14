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

        public void LoadDocument()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "PrintTest.docx");
            wordDoc = wordApp.Documents.Open(filePath, ReadOnly: true);
        }

        public void PrintDocumentTo(string printerName)
        {
            wordApp.ActivePrinter = printerName;
            wordDoc.PrintOut(Background: false, PrintToFile: false);
        }

        public void CloseDocument()
        {
            wordDoc.Close();
            wordApp.Quit();
        }
    }
}
