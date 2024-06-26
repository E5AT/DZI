using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<string> Parking = new List<string>();
            do
            {
                answer = Console.ReadLine();
                string[] words = answer.Split(' ');
                switch (words[0])
                {
                    case "Add":
                        Parking.Add(words[1]);
                        break;

                    case "Remove":
                        if(Parking.Contains(words[1]))
                            Parking.Remove(words[1]);
                        else Console.WriteLine($"Theres no car with plate {words[1]}");
                        break;

                    case "Update":
                        if

                }
            } while (answer != "END");
        }
    }
}
