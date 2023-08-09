using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshInkRegistryManager
{
    public static class RegistryManager
    {
        private const string _registryKeyPath = @"Software\FreshInk";
        public static string GetInstallPath()
        {
            string installPath;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(_registryKeyPath))
            {
                installPath = key?.GetValue("InstallPath") as string;
            }
            return installPath;
        }
        public static string GetConfigPath()
        {
            string configPath;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(_registryKeyPath))
            {
                configPath = key?.GetValue("ConfigPath") as string;
            }
            return configPath;
        }
    }
}
