using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            char text;
            string[] months = { "януари", "февруари", "март", "април", "май", "юни", "юли", "август", "септември", "октомври", "ноември", "декември" };
            do
            {
                text = char.Parse(Console.ReadLine());
                Console.WriteLine(months.Count(n => n.Contains(text)));
            } while (text >= 'а' && text <= 'я');
        }
    }
}
