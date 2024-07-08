using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                List<string> List = new List<string>();
                string answer;
                do
                {
                    answer = Console.ReadLine();
                    string[] words = answer.Split(' ');
                    switch (words[0])
                    {
                        case "Add":
                            for (int i = 1; i < words.Length; i++)
                                List.Add(words[i]);
                            break;

                        case "Update":
                            for (int i = 0; i < List.Count; i++)
                                List[i] = List[i].ToUpper()[0] + List[i].Substring(1);
                            break;

                        case "Remove":
                            List.RemoveAt(int.Parse(words[1]));
                            break;

                        case "Search":
                            if (List.Contains(words[1]))
                                Console.WriteLine(words[1]);
                            else Console.WriteLine("Not contained.");
                            break;

                        case "Length":
                            List<string> List1 = new List<string>();
                            for (int i = 0; i < List.Count; i++)
                                if (List[i].Length == int.Parse(words[1]))
                                    List1.Add(List[i]);
                            if (List1.Count != 0)
                                Console.WriteLine(string.Join("-", List1));
                            else Console.WriteLine("Not contained.");
                            break;

                        case "Insert":
                            if (List.Count < int.Parse(words[1]))
                                Console.WriteLine("There are not enough items in the list.");
                            else List.Insert(int.Parse(words[1]), words[2]);
                            break;

                        case "Print":
                            Console.WriteLine(string.Join("; ", List));
                            break;
                    }
                } while (answer != "END");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            }
    }
}
