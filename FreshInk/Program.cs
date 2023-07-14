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
            /*
             * Can use WordDocumentJob() instead to print the test 
             * word doc but requires word on the maachine
             */

            // Todo: Specify in the config file which test to use,
            //  this should only be listed once.
            //  Remove the count from the parsing, don't care about this.
            // add a way to specify the interval of tests to config file

            PrinterManager printerManager = PrinterManager.Instance(
                new JsonPrintTestConfigParser(),
                new PrintDocumentJob());
            printerManager.RunPrintTests();
            Environment.Exit(0);
        }
    }
}