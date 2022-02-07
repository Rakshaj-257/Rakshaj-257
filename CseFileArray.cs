using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToCsv
{
    class CseFileArray
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "I ";
            files[0, 1] = "am ";
            files[0, 2] = "From ";
            files[0, 3] = "Tumkur ";
            files[0, 4] = "Karnataka ";

            files[1, 0] = "Rakshaj ";
            files[1, 1] = "Tumkur ";
            files[1, 2] = "ssit ";
            files[1, 3] = "karnataka ";
            files[1, 4] = "6533108 ";

            StreamWriter sw = File.CreateText("Notes.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");
        }
    }
}