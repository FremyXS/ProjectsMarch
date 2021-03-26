using System;
using System.IO;
using System.Collections.Generic;

namespace Family
{
    class Program
    {
        public static string[] info { get; private set; } = File.ReadAllLines(@"..\\..\\..\\FamilyList.txt");
        public static int idEndListOfPeople { get; private set; } = 0;

        public static ListOfRelations relations { get; private set; }
        
        static void Main(string[] args)
        {

            WritePeople();

            relations = new ListOfRelations();

            InputId();
            

            
        }
        private static void WritePeople()
        {
            foreach(var i in info)
            {
                if (i == "") break;
                idEndListOfPeople++;
                Console.WriteLine(i);
            }
        }
        private static void InputId()
        {
            Console.WriteLine("\nВведите Id людей");

            Console.WriteLine(Relations.GetComparison(Console.ReadLine(), Console.ReadLine()));
        }
    }
    
    public class ListOfRelations
    {
        public List<List<string>> relationsList = new List<List<string>>();

        public ListOfRelations()
        {
            GetRelationsList();
        }
        private void GetRelationsList()
        {
            for(var i = Program.idEndListOfPeople + 1; i < Program.info.Length; i++)
            {
                relationsList.Add(GetRelations(i));
            }
        }
        private List<string> GetRelations(int i)
        {
            List<string> relations = new List<string>();

            relations.AddRange(Program.info[i].Split('<', '-', '>', '='));
            DeleteSpase(ref relations);

            return relations;
        }
        private void DeleteSpase(ref List<string> relations)
        {
            if (relations.Contains(""))
            {
                relations.Remove("");

                DeleteSpase(ref relations);
            }
        }
    }
    public class Relations
    {
        public static string GetComparison(string idFirst, string idSecond)
        {
            foreach(var i in Program.relations.relationsList)
            {
                if (i.Contains(idFirst) && i.Contains(idSecond)) return GetDefinite(i);
            }

            return "error";
        }
        private static string GetDefinite(List<string> relation)
        {
            return relation[2];
        }
    }
    public class ListOfPeople
    {
        public static int idEndListOfPeople { get; private set; }
        public Dictionary<string, List<string>> familydirect { get; private set; } = new Dictionary<string, List<string>>();
        public ListOfPeople()
        {
            Razbor();
        }
        private void Razbor()
        {
            List<string> listName = ParsingString(Program.info[0]);

            for (var i = 0; i < listName.Count; i++) familydirect.Add(listName[i], listik(i));

        }
        private List<string> ParsingString(string str)
        {
            List<string> listIndex = new List<string>();
            listIndex.AddRange(str.Split(';'));
            return listIndex;
        }
        private List<string> listik(int n)
        {
            List<string> names = new List<string>();

            for (var i = 1; i < Program.info.Length; i++)
            {
                if (Program.info[i] == "")
                {
                    idEndListOfPeople = i;
                    break;
                }

                names.Add(Program.info[i].Split(';')[n]);
            }

            return names;
        }
    }
}
