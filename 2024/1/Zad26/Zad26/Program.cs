using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<string> nums = new List<string>();
            List<int> count = new List<int>();
            for (int i = 0; i < 10; i++)
                count.Add(0);

            for (int i=a; i <= b; i++)
            {
                nums.Add((i).ToString());
            }

            for(int i = 0; i<nums.Count; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                    count[nums[i][j]-'0']++;
            }

            Console.WriteLine($"Digit {count.IndexOf(count.Max())} - {count.Max()} times");
        }
    }
}
