using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06._2
{
    class Person { }

    class Car
    {
        private string brand;
        private int hPower;
        public Car(string Brand, int HPower)
        {
            brand = Brand;
            hPower = HPower;
        }
        public override string ToString()
        {
            return $"{brand},{hPower}";
        }
    }

    class Pilot : Person
    {
        private string name, category;
        private int age;
        private Car carp;

        public Pilot(string name, int age, Car carp, string category)
        {
            this.name = name;
            this.age = age;
            this.carp = carp;
            this.category = category;
        }

        public override string ToString()
        {
            return $"{name},{age},{category},{carp.ToString()}";
        }
    }

    class Rally
    {
        private string name;
        private int year;
        List<Pilot> pilots;

        public Rally(string name, int year)
        {
            this.name = name;
            this.year = year;
            pilots = new List<Pilot>();
        }

        public void Add(Pilot pilot)
        {
            pilots.Add(pilot);
        }

        public void Info()
        {
            Console.WriteLine($"Rally: {name} - {year}");
            for (int i = 0; i < pilots.Count; i++)
                Console.WriteLine(pilots[i].ToString()); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char answer;
            string name, year;
            name = Console.ReadLine();
            year = Console.ReadLine();
            Rally rally = new Rally(name, int.Parse(year));
            do
            {
                Console.WriteLine("\n[a]dd [v]iew [q]uit");
                answer = char.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 'a':
                        string pName, category, brand;
                        int age, hPower;
                        Console.Write("Pilot name: "); pName = Console.ReadLine();
                        Console.Write("Age: "); age = int.Parse(Console.ReadLine());
                        Console.Write("Category (A|B|C): "); category = Console.ReadLine();
                        Console.Write("Car model: "); brand = Console.ReadLine();
                        Console.Write("Car power: "); hPower = int.Parse(Console.ReadLine());
                        Car car = new Car(brand, hPower);
                        Pilot pilot = new Pilot(pName, age, car, category);
                        rally.Add(pilot);
                        break;

                    case 'v':
                        rally.Info();
                        break;
                }
            } while (answer != 'q');
        }
    }
}
