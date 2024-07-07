using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad25
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                double a = int.Parse(Console.ReadLine());
                double b = int.Parse(Console.ReadLine());

                double answer = Math.Sqrt((b / a));
                if (a > 0 && b > 0) Console.WriteLine($"Решенията са (-{answer:f2}; {answer:f2})");
                else if (a < 0 && b < 0) Console.WriteLine($"Решенията са (-inf; -{answer:f2}) U ({answer:f2}; +inf)");
                else if (a == 0 && b > 0) Console.WriteLine("Всички реални числа са решения");
                else if (a == 0 || b == 0) Console.WriteLine("Няма реални решения");
                else Console.WriteLine("Всички реални числа са решения");
                }
            catch (Exception)
            {
                Console.WriteLine("Некоректно въведено число");
            }
            }
    }
}
