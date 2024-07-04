using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string answer = Console.ReadLine();
                List<char> text = answer.ToCharArray().ToList();
                for (int i = 0; i < text.Count - 1; i++)
                    while (text[i] == text[i + 1]) text.RemoveAt(i+1);

                Console.WriteLine(string.Join("",text));
            }
            catch(Exception)
            {
                return;
            }
        }
        }
    }
