using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06._3
{
    class Program
    {
        static int Sum(int num)
        {
            int sum = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                sum += (num.ToString()[i]-'0');
            }
            return sum;
        }
        static List<int> zad28_1(List<int> list, int k)
        {
            
            for(int i = 0; i < list.Count; i++)
            {
                int sum = Sum(list[i]);
                if (sum % k == 0) list.RemoveAt(i);
            }
            return list;
        }

        static List<int> zad28_2(List<int> list)
        {
            list.OrderBy(k => Sum(k));
            list.Reverse();
            return list;
        }

        static void Main(string[] args)
        {
            Console.Write("n = "); int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));
            Console.Write("K = "); int k = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", zad28_2(zad28_1(list,k))));
        }
    }
}
