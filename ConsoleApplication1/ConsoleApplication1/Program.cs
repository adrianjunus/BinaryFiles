using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringKata
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("File Path : ");
            string myFile = Console.ReadLine();
            if (!File.Exists(myFile + "TextFile.txt"))
            {
                // Create file and put some text in it.
                using (StreamWriter sw = File.CreateText(@myFile))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And Welcome");
                }

            }
        }
    }
}
