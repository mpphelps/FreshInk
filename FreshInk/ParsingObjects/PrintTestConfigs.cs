using System.Collections.Generic;

namespace FreshInk
{
    internal class PrintTestConfigs
    {
        public string TestDocument { get; set; }
        public int TestInterval { get; set; }
        public List<PrintTestConfig> Configs { get; set; }
        

        public PrintTestConfigs()
        {
            TestDocument = "Default";
            TestInterval = 14;
            Configs = new List<PrintTestConfig>();
            
        }
    }

}
