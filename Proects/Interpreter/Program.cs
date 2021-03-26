using System;
using System.IO;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        public static string[] info { get; set; } = File.ReadAllLines(@"..\\..\\..\\Commands.txt");
        public static List<List<string>> commandsList = new List<List<string>>();
        static void Main(string[] args)
        {
            ReceivingCommand();
            SetCommand();

            foreach (var i in Commands.peremens.Values)
                Console.WriteLine(i);

        }
        static void ReceivingCommand()
        {
            foreach (string i in info)
            {
                var work = new WorkWithFile(i);
                commandsList.Add(work.entireCodeTeam);
            }
        }
        static void SetCommand()
        {
            foreach (List<string> i in commandsList)
            {
                Commands.GetCommand(i);
            }
        }
    }
}

