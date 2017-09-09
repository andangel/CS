using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace A02File类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./File类.txt";
            if (!File.Exists(path))//
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
