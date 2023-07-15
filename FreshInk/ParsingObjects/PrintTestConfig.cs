using System;
using System.Collections.Generic;

namespace FreshInk
{
    internal class PrintTestConfig
    {
        public string TestDocument { get; set; }
        public int TestInterval { get; set; }
        public DateTime TargetDate { get; set; }
        public List<string> PrinterNames { get; set; }

        public PrintTestConfig()
        {
            TestDocument = "Default";
            TestInterval = 14;
            TargetDate = DateTime.Now;
            PrinterNames = new List<string>();
            
        }
    }

}
