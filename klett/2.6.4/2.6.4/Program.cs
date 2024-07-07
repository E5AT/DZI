using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2._6._4
{
    class Student
    {
        public string name;
        public double uspeh;
        public Student(string name, double uspeh)
        {
            this.name = name;
            this.uspeh = uspeh;
        }
        public override string ToString()
        {
            return $"{name} - {uspeh}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            StreamReader r = new StreamReader($"E:\\DZI\\klett\\2.6.4\\{answer}.txt");
            List<Student> students = new List<Student>();
            string line = "";
            while (true)
            {
                line = r.ReadLine();
                    if (line == null) break;
                string[] lineElements = line.Split(' ');
                Student student = new Student(lineElements[0] +" "+ lineElements[1], double.Parse(lineElements[3]));
                students.Add(student);
            }

            StreamWriter w = new StreamWriter($"E:\\DZI\\klett\\2.6.4\\{answer}sorted.txt");
            foreach(Student student in students.OrderBy(s => s.uspeh).ThenBy(s => s.name).Reverse())
                w.WriteLine(student.ToString());
            r.Close();  w.Close();
        }
    }
}
