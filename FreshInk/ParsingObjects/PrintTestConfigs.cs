using System.Collections.Generic;

namespace FreshInk
{
    internal class PrintTestConfigs
    {
        public List<PrintTestConfig> Configs { get; set; }
        public int Count { get; set; }

        public PrintTestConfigs()
        {
            Configs = new List<PrintTestConfig>();
            Count = 0;
        }
    }

}
