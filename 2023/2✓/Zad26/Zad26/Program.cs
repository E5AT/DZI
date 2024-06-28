using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static int ReadPoints(List<double> points)
        {
            points.RemoveAll(p => p <= 0);
            return points.Count;
        }


        static double MinDpoints(List<double> points)
        {
            List<double> razlikas = new List<double>();
            points.Sort();
            points.Reverse();
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    double num = points[i] - points[j];
                    if (num > 0)
                        razlikas.Add(num);
                }
            }
            return razlikas.Min();
        }

        static int Laureates(List<double> points)
        {
            int laurates = 0;
            points.Sort();
            points.Reverse();
            for (int i = 0; i < 3; i++)
            {
                double num = points[0];
                laurates += points.Count(n => n == num);
                points.RemoveAll(n => n == num);
            }
            return laurates;
        }

        static void Main(string[] args)
        {
            int answer = int.Parse(Console.ReadLine());
            List<double> point = new List<double>();
            for (int i = 0; i < answer; i++)
            {
                point.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("valid works - " + ReadPoints(point));
            Console.WriteLine("minimal difference - " + Math.Round(MinDpoints(point), 3) + " p.");
            Console.WriteLine("laureates - " + Laureates(point));
        }
    }
}


