using Newtonsoft.Json;
using System;
using System.IO;

namespace FreshInkUtilities
{
    public class JsonPrintTestConfigParser : IPrintTestConfigParser
    {
        private string _filePath;
        public JsonPrintTestConfigParser()
        {
            string configPath = RegistryManager.GetConfigPath();
            if (configPath != null)
            {
                if (!Directory.Exists(configPath))
                {
                    Directory.CreateDirectory(configPath);
                }
            }
            else
            {
                throw new Exception("Missing registry key for config path.  Try reinstalling application.");
            }
                
                
            _filePath = Path.Combine(configPath, "TestConfig.json");
        }

        public JsonPrintTestConfigParser(string filePath)
        {
            _filePath = filePath;
        }


        public PrintTestConfig GetConfigs()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    string json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<PrintTestConfig>(json);
                }
                catch (JsonException ex)
                {
                    FileLogger.LogError("Error deserializing JSON, using default test.", ex);
                }

            }
            var defaultConfig = new PrintTestConfig();
            defaultConfig.PrinterNames.Add("Microsoft Print to PDF");
            return defaultConfig;
        }
        public void SaveConfigs(PrintTestConfig config)
        {
            try
            {
                string json = JsonConvert.SerializeObject(config);
                File.WriteAllText(_filePath, json);
            }
            catch (JsonException ex)
            {
                FileLogger.LogError("Error serializing JSON", ex);
            }
            catch (IOException ex)
            {
                FileLogger.LogError("Error writing to file", ex);
            }
        }
    }
}
