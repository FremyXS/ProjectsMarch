using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimulatorCMD
{
    public class Commands
    {
        private string command { get; set; }
        private List<string> commandList = new List<string>();
        public Commands(string command)
        {
            this.command = command;
            GetPartsOfCommand();
            GetCommand();
        }
        private void GetCommand()
        {
            switch (commandList[0])
            {
                case "cd":
                    SetCd();
                    break;
                case "new":
                    SetNew();
                    break;
                case "delete":
                    SetDelete();
                    break;
            }
        }
        private void SetNew()
        {
            File.Create($"{Program.path}/{commandList[1]}.{commandList[2]}");
        }
        private void SetDelete()
        {
            File.Delete($"{Program.path}/{commandList[1]}.{commandList[2]}");
        }
        private void SetCd()
        {
            List<string> pathList = new List<string>();
            pathList.AddRange(Program.pathCopy.Split('\\'));

            NameConnection();

            if (commandList[1] == ".")
                SetMove(pathList.Count - 2, pathList);
            else
                MoveInName(pathList);

        }
        private void MoveInName(List<string> pathList)
        {
            if (pathList.Contains(commandList[1]))
                SetMove(pathList.Count - (pathList.Count - pathList.IndexOf(commandList[1])) + 1, pathList);
            else
            {
                pathList.RemoveAt(pathList.Count - 1);
                pathList.Add(commandList[1]);
                SetMove(pathList.Count, pathList);
            }
        }
        private void NameConnection()
        {
            if (commandList.Count > 2)
            {
                for (var i = 2; i < commandList.Count; i++)
                {
                    commandList[1] += " " + commandList[i];
                    commandList.RemoveAt(i);
                }
            }
        }
        private void SetMove(int value, List<string> pathList)
        {
            string path = "";

            for (var i = 0; i < value; i++)
            {
                path += pathList[i] + "\\";
            }

            Program.path = $@"{path}";
        }
        private void GetPartsOfCommand()
        {
            commandList.AddRange(command.Split(' '));
            DeleteSpace();
        }
        private void DeleteSpace()
        {
            if (commandList.Contains(""))
            {
                commandList.Remove("");
                DeleteSpace();
            }
        }
    }
}
