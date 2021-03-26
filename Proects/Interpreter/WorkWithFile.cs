using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class WorkWithFile
    {
        private string command { get; set; }
        public List<string> entireCodeTeam { get; private set; } = new List<string>();
        public WorkWithFile(string command)
        {
            this.command = command;
            entireCodeTeam.AddRange(command.Split(' ', ','));
            DeleteSpace();
        }
        private void DeleteSpace()
        {
            if (entireCodeTeam.Contains(""))
            {
                entireCodeTeam.Remove("");
                DeleteSpace();
            }
        }
    }
}
