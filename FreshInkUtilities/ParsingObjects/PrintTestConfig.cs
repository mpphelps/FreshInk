using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshInkUtilities
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
