using System;
using System.Text;
using System.IO;
using System.Linq;

namespace Codir
{
    class Program
    {
        static void Main(string[] args)
        {
            //string simple = Console.ReadLine();
            //var simpleBytes = Encoding.UTF8.GetBytes(simple);
            //var enText = Convert.ToBase64String(simpleBytes);
            //Console.WriteLine(enText);

            EncodingHTML.GetCommand(Console.ReadLine().Split(' '));
        }       
    }
    public class EncodingHTML
    {
        public static void GetCommand(string[] command)
        {
            if (command.Contains("—source") && command.Contains("buffer")) EncodingInHTML(command);
            else if (command.Contains("—s") && command.Contains("file")) EncodingInText(command);
        }
        private static void EncodingInText(string[] command)
        {
            var enText = File.ReadAllBytes($@"..\\..\\..\\{command[command.Length-2]}");

            var basText = Convert.ToBase64String(enText);

            File.WriteAllText($@"..\\..\\..\\suka.txt", basText);

        }
        private static void EncodingInHTML(string[] command)
        {

        }
    }


}
