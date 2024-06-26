using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static int Factoriel(int num)
        {
            if (num == 1) return 1;
            else return num * Factoriel(num - 1);
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(num));
        }
    }
}
