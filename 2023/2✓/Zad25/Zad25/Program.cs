using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad25
{
    class Program
    {
        static bool Poliandrome(char[] num)
        {
            string number = "", numb = string.Join("", num); ;
            for (int i = num.Length-1; i >= 0; i--)
                number += num[i];
            if ( numb== number) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            try {
                string num = Console.ReadLine();
                if (int.Parse(num) < 0) throw new Exception();
                else if (Poliandrome(num.ToCharArray())) Console.WriteLine($"{num} is a poliandrome");
                else Console.WriteLine($"{num} is not a poliandrome");
            }
            catch(Exception)
            {
                Console.WriteLine("Incorrectly entered number");
            }
            }
    }
}
