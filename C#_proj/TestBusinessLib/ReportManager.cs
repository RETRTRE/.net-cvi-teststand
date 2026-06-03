using System;
using System.IO;
using System.Text.Json;

namespace TestBusinessLib
{
    public class ReportManager
    {
        /// <summary>
        /// 将测试结果导出为 JSON 文件
        /// </summary>
        public string ExportToJson(TestResult result, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(result, options);
            File.WriteAllText(filePath, json);

            return filePath;
        }
    }
}