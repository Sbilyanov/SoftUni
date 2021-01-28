using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directoryPath);

            Dictionary<string, Dictionary<string, double>> fileData = new Dictionary<string, Dictionary<string, double>>();

            foreach (var fileName in fileNames)
            {

                FileInfo fileInfo = new FileInfo(fileName);
                string extention = fileInfo.Extension;
                double size = Math.Round(fileInfo.Length / 1024.0, 3);
                if (!fileData.ContainsKey(extention))
                {
                    fileData.Add(extention, new Dictionary<string, double>());
                }

                fileData[extention].Add(fileInfo.Name, size);
            }
            fileData = fileData.OrderByDescending(v => v.Value.Count).ThenBy(k => k.Key)
                       .ToDictionary(k => k.Key, v => v.Value);

            List<string> output = new List<string>();

            foreach (var extent in fileData)
            {
                output.Add(extent.Key);

                foreach (var val in extent.Value.OrderBy(v=>v.Value))
                {
                    output.Add($"--{val.Key} - {val.Value}kb");
                }
            }


            string outputPath =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.txt");
            File.WriteAllLines(outputPath, output);
        }
    }
}
