using System;
using System.Collections.Generic;
using System.Text;

namespace WrteOfTime
{
    public class WriteConsole
    {
        public static void GetTabl()
        {
            for (var i = 0; i < 30; i++)
            {
                if (i == 0) GetOneString('┌', '┐', '─');
                else if (i == 29) GetOneString('└', '┘', '─');
                else GetOneString('│', '│', ' ');
            }

        }
        private static void GetOneString(char x1, char x3, char x2)
        {
            for (var j = 0; j < 60; j++)
            {
                if (j == 0) Console.Write(x1);
                else if (j == 59) Console.Write(x3);
                else Console.Write(x2);
            }
            Console.WriteLine();
        }
        public static void GetWordOnTabl(int time)
        {
            foreach (List<string> i in Program.ListWords)
            {
                if (SettingsOfText.SetTime(i, time))
                {
                    SetSettings(i);
                }
            }
        }
        private static void SetSettings(List<string> i)
        {
            if (i.Contains("Top") || i.Contains("Bottom") || i.Contains("Right") || i.Contains("Left"))
            {
                SetPosition(i[2], SettingsOfText.SetText(i, 4));

                Console.ForegroundColor = SettingsOfText.SetColor(i[3]);
                Console.WriteLine(SettingsOfText.SetText(i, 4));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                SetPosition("Bottom", SettingsOfText.SetText(i, 2));
                Console.WriteLine(SettingsOfText.SetText(i, 2));
            }
        }
        private static void SetPosition(string position, string text)
        {
            switch (position)
            {
                case "Top":
                    Console.SetCursorPosition(30 - text.Length / 2, 1);
                    break;
                case "Bottom":
                    Console.SetCursorPosition(30 - text.Length / 2, 28);
                    break;
                case "Left":
                    Console.SetCursorPosition(1, 15);
                    break;
                case "Right":
                    Console.SetCursorPosition(59 - text.Length, 15);
                    break;
            }
        }
    }
}
