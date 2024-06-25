using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_25
{
    class Program
    {
        static bool zad25(int num)
        {
            char[] nums = num.ToString().ToCharArray();
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == '-') break;
                else if (num % (nums[i] - '0') != 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (zad25(num)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
