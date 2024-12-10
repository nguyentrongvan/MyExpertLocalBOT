using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatbotGUI.Commands
{
    internal class ConfigReader
    {
        private readonly Dictionary<string, Dictionary<string, string>> _configData;

        public ConfigReader(string filePath)
        {
            _configData = new Dictionary<string, Dictionary<string, string>>();
            LoadConfig(filePath);
        }

        private void LoadConfig(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Configuration file not found: {filePath}");
            }

            string currentSection = string.Empty;

            foreach (var line in File.ReadAllLines(filePath))
            {
                string trimmedLine = line.Trim();

                // Skip empty lines or comments
                if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith(";") || trimmedLine.StartsWith("#"))
                    continue;

                // Section header
                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentSection = trimmedLine.Trim('[', ']');
                    if (!_configData.ContainsKey(currentSection))
                    {
                        _configData[currentSection] = new Dictionary<string, string>();
                    }
                }
                // Key-Value pair
                else if (trimmedLine.Contains("="))
                {
                    var keyValue = trimmedLine.Split(new[] { '=' }, 2);
                    if (keyValue.Length == 2 && !string.IsNullOrEmpty(currentSection))
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();
                        _configData[currentSection][key] = value;
                    }
                }
            }
        }

        public string Get(string section, string key)
        {
            if (_configData.TryGetValue(section, out var sectionData) && sectionData.TryGetValue(key, out var value))
            {
                return value;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in section '{section}'.");
        }

        public string GetOrDefault(string section, string key, string defaultValue)
        {
            if (_configData.TryGetValue(section, out var sectionData) && sectionData.TryGetValue(key, out var value))
            {
                return value;
            }

            return defaultValue;
        }
    }
}
