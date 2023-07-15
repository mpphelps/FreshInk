using System;
using System.Drawing;
using System.Drawing.Printing;

namespace FreshInk
{
    internal class PrintDocumentJob : IPrintJob
    {
        PrintDocument printDocument;

        public PrintDocumentJob()
        {
            printDocument = new PrintDocument();
        }

        public void LoadDocument(string fileName)
        {
            if (fileName != "Default")
            {
                FileLogger.LogError("Invalid document to print.");
            }
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void PrintDocumentTo(string printerName)
        {
            printDocument.PrinterSettings.PrinterName = printerName;
            printDocument.Print();
        }

        public void CloseDocument()
        {
            printDocument.Dispose();
        }

        private static void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 11);
            string testContent = "This is a test page.";
            float startY = 10f; // Starting Y coordinate

            for (int i = 0; i < 43; i++)
            {
                PointF startPoint = new PointF(10f, startY);

                graphics.DrawString(testContent, font, Brushes.Red, startPoint);
                startPoint.Y += font.Height; // Adjust Y coordinate

                graphics.DrawString(testContent, font, Brushes.Green, startPoint);
                startPoint.Y += font.Height;

                graphics.DrawString(testContent, font, Brushes.Blue, startPoint);
                startPoint.Y += font.Height;

                graphics.DrawString(testContent, font, Brushes.Cyan, startPoint);
                startPoint.Y += font.Height;

                graphics.DrawString(testContent, font, Brushes.Magenta, startPoint);
                startPoint.Y += font.Height;

                graphics.DrawString(testContent, font, Brushes.Yellow, startPoint);
                startPoint.Y += font.Height;

                graphics.DrawString(testContent, font, Brushes.Black, startPoint);
                startPoint.Y += font.Height;
            }
        }
    }
}
