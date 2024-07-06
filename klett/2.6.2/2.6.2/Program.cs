using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("E:\\DZI\\klett\\2.6.2\\birthPlace.txt");
            string line = "";
            List<string> cities = new List<string>();
            while (true)
            {
                line = r.ReadLine();
                if (line == null) break;
                cities.Add(line.Split(' ')[3]);
            }

            List<int> count = new List<int>();
            for (int i = 0; i < cities.Count; i++)
                count.Add(cities.Count(c => c == cities[i]));
            Console.WriteLine(cities[count.IndexOf(count.Max())]+" "+count.Max());
        }
    }
}
