using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Printing;
using FreshInk;

namespace PrinterTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterManager printerManager = PrinterManager.Instance();
            printerManager.RunPrintTests();
            Environment.Exit(0);
        }
    }
}