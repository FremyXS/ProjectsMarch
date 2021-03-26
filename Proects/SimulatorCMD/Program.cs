using System;
using System.IO;
using System.Collections.Generic;

namespace SimulatorCMD
{
    class Program
    {
        public static string path { get; set; }
        public static string pathCopy { get; private set; }
        static void Main(string[] args)
        {
            path = @"..\\..\\..\\..\\SimulatorCMD";
            string command;

            do 
            {
                GetContent();

                command = Console.ReadLine();
                new Commands(command);

                Console.Clear();

            } while (command != "exit");
        }
        static void GetContent()
        {
            var direct = new DirectoryInfo(path);

            foreach (var i in direct.GetFiles())
            {
                Console.WriteLine(i);
            }
            foreach (var i in direct.GetDirectories())
            {
                pathCopy = i.ToString();
                Console.WriteLine(i);
            }
        }
    }
    
}
