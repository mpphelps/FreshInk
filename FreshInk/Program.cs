using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Printing;
using FreshInk;
using FreshInkUtilities;

namespace PrinterTestApp
{
    class FreshInkProgram
    {
        static void Main(string[] args)
        {
            PrinterManager printerManager = PrinterManager.Instance();
            printerManager.RunPrintTests();
            FileLogger.LogInformation($"FreshInk completed.");
        }
    }
}