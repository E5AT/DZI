using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_26
{
    class Human
    {
        public string firstName, lastName;
        public int age;

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {age} years old";
        }
    }

    class Student : Human
    {
        public double grade;

        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {age} years old, grade: {grade:f2}";
        }
    }

    class Worker: Human
    {
        public double wage;
        public int workHours;

        public Worker(string firstName, string lastName, int age, double wage, int workHours) : base(firstName, lastName, age)
        {
            this.wage = wage;
            this.workHours = workHours;
        }

        public double Salary()
        {
            return wage * workHours;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {age} years old, salary: ${Salary():f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            Student student;
            Worker worker;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("First name: "); string firstName = Console.ReadLine();
                Console.Write("Last name: "); string lastName = Console.ReadLine();
                Console.Write("Age: "); int age = int.Parse(Console.ReadLine());
                Console.Write("Your choice [s - student], [w - worker]:"); string answer = Console.ReadLine();
                switch (answer)
                {
                    case "s":
                        Console.Write("Grade: "); double grade = double.Parse(Console.ReadLine());
                        student = new Student(firstName, lastName, age, grade);
                        humans.Add(student);
                        break;

                    case "w":
                        Console.Write("Wage: "); double wage = double.Parse(Console.ReadLine());
                        Console.Write("Work hours: "); int workHours = int.Parse(Console.ReadLine());
                        worker = new Worker(firstName, lastName, age, wage, workHours);
                        humans.Add(worker);
                        break;
                }
            }

            humans.Reverse();
            for (int i = 0; i < humans.Count; i++)
            {
                Console.WriteLine(humans[i].ToString());
            }
        }
    }
}
