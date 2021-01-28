using System;
using System.IO;
using System.IO.Compression;

namespace _07.TwoZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string path =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "copyMeTwo.zip");
            using (ZipArchive archive = ZipFile.Open(path, ZipArchiveMode.Create)) 
            {
                archive.CreateEntryFromFile("copyMeTwo.png", "copY.png");
            }
        }
    }
}
