using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string illegal = Console.ReadLine();

            answer = answer.ToLower();
            List<string> illegalWords = illegal.Split(',').ToList();
            
                    for(int i = 0; i < illegalWords.Count; i++)
                    {
                        if (illegalWords[i].Contains(" ")) illegalWords[i].Replace(" ", "");
                    }

            for (int i = 0; i < illegalWords.Count; i++)
                while (answer.Contains(illegalWords[i]))
                    answer = answer.Replace(illegalWords[i], "***");

            Console.WriteLine(answer);
        }
    }
}
