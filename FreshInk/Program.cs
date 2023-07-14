using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using FreshInk;
using Newtonsoft.Json;

namespace PrinterTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterManager printerManager = PrinterManager.Instance(
                new JsonPrintTestConfigParser(),
                new PrintDocumentJob());
            printerManager.RunPrintTests();
            Environment.Exit(0);
        }
    }
}