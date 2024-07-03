using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int SC = int.Parse(Console.ReadLine());
            int SM = int.Parse(Console.ReadLine());
            int TC = int.Parse(Console.ReadLine());
            int TM = int.Parse(Console.ReadLine());

            int hour = SC + TC;
            int minute = SM + TM;

            while(true)
            {
                if (hour >= 24) hour -= 24;
                else if (minute >= 60) hour += 1;
                else break;
            }

            string text = "";
            if (hour < 10) text += "0"; text += hour + ":";
            if (minute < 10) text += "0"; text += minute;

            Console.WriteLine(text);
            
        }
    }
}
