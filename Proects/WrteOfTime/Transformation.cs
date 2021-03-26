using System;
using System.Collections.Generic;
using System.Text;

namespace WrteOfTime
{
    public class Transformation
    {
        private string oneString;
        public List<string> listOneString { get; }
        public Transformation(string oneString)
        {
            listOneString = new List<string>();
            this.oneString = oneString;
            GetListOfString();
        }
        private void GetListOfString()
        {
            listOneString.AddRange(oneString.Split(' ', '[', ']', '-', ','));
            DeliteSpace();
        }
        private void DeliteSpace()
        {
            if (listOneString.Contains(""))
            {
                listOneString.Remove("");
                DeliteSpace();
            }
        }

    }
}
