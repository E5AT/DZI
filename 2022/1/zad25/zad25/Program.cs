using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int j = 0; j < i; j++)
                nums.Add(int.Parse(Console.ReadLine()));

            while (true)
            {
                int num = nums[0];
                Console.WriteLine($"число: {num}, брой: {nums.Count(n => n == num)}");
                nums.RemoveAll(n => n == num);
                if (nums.Count == 0) break;
            }


        }
    }
}
