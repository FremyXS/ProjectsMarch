using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace WrteOfTime
{
    class Program
    {
        private static List<List<string>> listWords;
        public static List<List<string>> ListWords { get { return listWords; } }
        static void Main(string[] args)
        {
            listWords = new List<List<string>>();
            WorkWithFile.GetInfo(ref listWords);

            int time = 0;

            do
            {
                Console.Clear();

                WriteConsole.GetTabl();
                WriteConsole.GetWordOnTabl(time);

                Thread.Sleep(1000);
                time++;

            } while (1 > 0);            
        }

        
    }   
}
