using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshInkUtilities
{
    public interface IPrintTestConfigParser
    {
        PrintTestConfig GetConfigs();
        void SaveConfigs(PrintTestConfig config);
    }
}
