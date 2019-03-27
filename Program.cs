using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("e.g. D://folder//test.txt \n");
            while (true)
            {
                string name = Console.ReadLine();
                if (System.IO.File.Exists(name))
                {
                    System.Diagnostics.Process.Start(name);
                }
                else
                {
                    Console.WriteLine("file name is not exists");
                }
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
            }
        }
    }
}
