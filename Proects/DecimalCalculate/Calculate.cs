using System;
using System.Collections.Generic;
using System.Text;

namespace DecimalCalculate
{
    public class Calculate
    {
        private static List<string> functionList = new List<string>();
        public static List<string> FunctionList { get { return functionList; } }

        private Decimal one;
        private Decimal two;
        public Calculate(List<string> function)
        {
            functionList = function;

            GetNewFunction();

        }
        private void GetNewFunction()
        {
            if (!GetInfoOfOperat())
                return;
            else
            {
                GetSecondPriority(GetOperat());

                GetNewFunction();
            }
        }
        private bool GetInfoOfOperat()
        {
            if (functionList.Contains("+") || functionList.Contains("-") || functionList.Contains("*") || functionList.Contains("//"))
                return true;
            else
                return false;
        }
        private string GetOperat()
        {
            if (functionList.Contains("*"))
                return "*";
            else if (functionList.Contains("//"))
                return "//";
            else if (functionList.Contains("-"))
                return "-";
            else
                return "+";
        }
        private void GetSecondPriority(string op)
        {
            int ind = functionList.IndexOf(op);

            one = new Decimal(functionList[ind - 1]);
            two = new Decimal(functionList[ind + 1]);

            SetNewDec(op, ind);

            for (var i = 0; i < 3; i++)
                functionList.RemoveAt(ind);
        }
        private void SetNewDec(string op, int ind)
        {
            if (op == "+")
                functionList.Insert(ind - 1, (one + two).ToString());
            else if (op == "-")
                functionList.Insert(ind - 1, (one - two).ToString());
            else if (op == "*")
                functionList.Insert(ind - 1, (one * two).ToString());
            else
                functionList.Insert(ind - 1, (one / two).ToString());
        }
    }
}
