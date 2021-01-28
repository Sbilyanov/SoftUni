using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            string filePath = Path.Combine("..","..","..","output.zip");
            string file = "copyMe.png";

            using ZipArchive zipArchive = ZipFile.Open(filePath, ZipArchiveMode.Create);
                 zipArchive.CreateEntryFromFile(file, Path.GetFileName(file));
                
        }
    }
}
