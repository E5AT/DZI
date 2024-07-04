using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");  int n = int.Parse(Console.ReadLine());
            if (n < 3) throw new Exception("n >= 3 !!!");
            List<int> nums = new List<int>();
            for(int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }
            nums.Sort();
            nums.Reverse();
            List<double> sortedNums = new List<double>();
            for(int i = 0; i < nums.Count-1; i++)
            {
                sortedNums.Add(nums[i] - nums[i+1]);
            }
            Console.WriteLine(sortedNums.Min());
        }
    }
}
