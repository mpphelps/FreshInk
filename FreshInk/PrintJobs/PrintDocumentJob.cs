using FreshInkLogger;
using Microsoft.Office.Interop.Word;
using System;
using System.Drawing;
using System.Drawing.Printing;


namespace FreshInk
{
    internal class PrintDocumentJob : IPrintJob
    {
        private PrintDocument printDocument;

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
            var font = new System.Drawing.Font("Arial", 10);
            string testContent = "This is a test page.";
            float startY = 10f; // Starting Y coordinate
            float lengthMultiplier = 6;

            PointF startPoint = new PointF(10f, startY);

            var colors = new Brush[] { 
                Brushes.Red,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Cyan,
                Brushes.Magenta,
                Brushes.Yellow,
                Brushes.Black
            };

            int c = 0;
            startPoint.Y = 50;
            for (int i = 0; i < 62; i++)
            {
                startPoint.X = 65;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                graphics.DrawString(testContent, font, colors[c++], startPoint);
                if (c == colors.Length) c = 0;
                startPoint.X += testContent.Length * lengthMultiplier;

                startPoint.Y += font.Height;
            }
        }
    }
}
