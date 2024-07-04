using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            List<string> words = answer.Split(' ').ToList();

            Console.WriteLine(words.Max().Length);
        }
    }
}
