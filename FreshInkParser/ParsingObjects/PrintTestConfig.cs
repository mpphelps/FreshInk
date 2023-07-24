using System;
using System.Collections.Generic;

namespace FreshInkParser
{
    public class PrintTestConfig
    {
        public string TestDocument { get; set; }
        public List<string> PrinterNames { get; set; }

        public PrintTestConfig()
        {
            TestDocument = "Default";
            PrinterNames = new List<string>();
        }
    }

}
