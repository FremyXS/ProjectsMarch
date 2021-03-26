using System;
using System.Collections.Generic;
using System.Text;

namespace WrteOfTime
{
    public class SettingsOfText
    {
        private static Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
        public static ConsoleColor SetColor(string color)
        {
            foreach (var i in consoleColors)
            {
                if (i.ToString() == color)
                    return (ConsoleColor)i;
            }

            return ConsoleColor.White;
        }
        public static string SetText(List<string> str, int i)
        {
            string text = "";

            for (; i < str.Count; i++)
                text += str[i] + " ";

            return text.Trim();
        }
        public static bool SetTime(List<string> str, int time)
        {
            string[] one = str[0].Split(new char[] { ':' });
            string[] two = str[1].Split(new char[] { ':' });

            for (var i = int.Parse(one[0]) * 60 + int.Parse(one[1]); i <= int.Parse(two[0]) * 60 + int.Parse(two[1]); i++)
            {
                if (time >= i && time <= i)
                    return true;
            }

            return false;
        }
    }
}
