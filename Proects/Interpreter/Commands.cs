using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Commands
    {
        public static Dictionary<string, int> peremens { get; private set; } = new Dictionary<string, int>();
        public static void GetCommand(List<string> command)
        {
            switch (command[0])
            {
                case "var":
                    SetVar(command);
                    break;
                case "add":
                    SetAdd(command);
                    break;
                case "sub":
                    SetSub(command);
                    break;
                case "div":
                    SetDiv(command);
                    break;
                case "mul":
                    SetMul(command);
                    break;
            }
        }
        private static void SetVar(List<string> command)
        {
            peremens.Add(command[1], 0);
        }
        private static void SetAdd(List<string> command)
        {
            peremens[command[1]] += GetValue(command[2]);
        }
        private static void SetSub(List<string> command)
        {
            peremens[command[1]] -= GetValue(command[2]);
        }
        private static void SetDiv(List<string> command)
        {
            peremens[command[1]] /= GetValue(command[2]);
        }
        private static void SetMul(List<string> command)
        {
            peremens[command[1]] *= GetValue(command[2]);
        }
        private static int GetValue(string value)
        {
            if (GetInfo(value)) return peremens[value];
            else return int.Parse(value);
        }
        private static bool GetInfo(string value)
        {
            foreach (var i in peremens.Keys)
                if (value == i) return true;

            return false;
        }
    }
}
