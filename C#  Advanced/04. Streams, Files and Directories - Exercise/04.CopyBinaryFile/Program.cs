using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream reader = new FileStream("copyMe.png", FileMode.Open);
            using FileStream writer = new FileStream("../../../newImage.png", FileMode.Create);

            while (true)
            {
                byte[] buffer = new byte[4096];
                int count = reader.Read(buffer, 0, buffer.Length);

                if (count==0)
                {
                    break;
                }
                writer.Write(buffer);
            }
        }
    }
}
