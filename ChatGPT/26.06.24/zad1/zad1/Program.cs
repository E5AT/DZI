using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string[] list = answer.Split(' ');
            Console.WriteLine(string.Join(" ",list.OrderBy(k=>k.Length)));
        }
    }
}
