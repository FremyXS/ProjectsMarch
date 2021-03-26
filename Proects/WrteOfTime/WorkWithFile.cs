using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WrteOfTime
{
    public class WorkWithFile
    {
        public static string[] info = File.ReadAllLines(@"..\\..\\..\\info.txt");
        public static void GetInfo(ref List<List<string>> listWords)
        {
            for (var i = 0; i < info.Length; i++)
            {
                var procces = new Transformation(info[i]);
                listWords.Add(procces.listOneString);
            }
        }
    }
}
