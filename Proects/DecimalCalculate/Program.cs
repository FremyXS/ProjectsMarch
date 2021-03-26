using System;
using System.Collections.Generic;

namespace DecimalCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();

            List<string> functionList = new List<string>();

            functionList.AddRange(function.Split(new char[] { ' ' }));

            new Calculate(functionList);

            foreach (var i in Calculate.FunctionList)
                Console.Write(i);
            Console.WriteLine();
        }
    }
}
