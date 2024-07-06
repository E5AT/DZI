using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("E:\\DZI\\klett\\2.6.1\\names.txt");
            List<string> students = new List<string>();
            string line = "";
            while (line != null)
            {
                line = r.ReadLine();
                students.Add(line);
            }
            int n = int.Parse(Console.ReadLine());
            if (n > students.Count) Console.WriteLine("Няма достатъчно данни!");
            else 
                for(int i = 0; i < n; i++)
                    Console.WriteLine(students[i]);
        }
    }
}
