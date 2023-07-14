using Newtonsoft.Json;
using System;
using System.IO;

namespace FreshInk
{
    internal class JsonPrintTestConfigParser : IPrintTestConfigParser
    {
        private string _filePath;
        public JsonPrintTestConfigParser()
        {
            _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "TargetDate.json");
        }

        public JsonPrintTestConfigParser(string filePath)
        {
            _filePath = filePath;
        }


        public PrintTestConfigs ParsePrintTestConfigs()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    string json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<PrintTestConfigs>(json);
                }
                catch(JsonException ex)
                {
                    throw new Exception("Error deserializing JSON", ex);
                }
                
            }
            else
            {
                var defaultConfig = new PrintTestConfigs();
                defaultConfig.Configs.Add(new PrintTestConfig()
                {
                    TargetDate = DateTime.Now.Date,
                    PrinterName = "Microsoft Print to PDF"
                });
                return defaultConfig;
            }
        }
        public void SerializePrintTestConfigs(PrintTestConfigs config)
        {
            try
            {
                string json = JsonConvert.SerializeObject(config);
                File.WriteAllText(_filePath, json);
            }
            catch (JsonException ex)
            {
                throw new Exception("Error serializing JSON", ex);
            }
            catch (IOException ex)
            {
                throw new Exception("Error writing to file", ex);
            }
        }
    }
}
