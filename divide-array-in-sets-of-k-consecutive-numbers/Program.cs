using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_array_in_sets_of_k_consecutive_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 15,2, 1, 2, 3, 17, 4, 3, 4, 16, 5, 9, 10, 11 };
            int[] sorted = { 1, 2, 2, 3, 3, 3, 4, 4, 5, 9, 10, 11 };

            int k = 3;

            Console.Write(IsPossibleDivide(nums, k).ToString());
            Console.ReadKey();
        }

        static bool IsPossibleDivide(int[] nums, int k)
        {
            List<int> list = nums.ToList();
            list.Sort();
            foreach (int i in list)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();

            int length = nums.Length;

            int m = length % k;

            if (m != 0)
            {
                return false;
            }

            int r = length / k;

            for (int b = 0; b < r; b++)
            {
                int n = 0;
                int l = 0;
                for (int i = 0; i < k; i++)
                {

                    if (i == 0)
                    {
                        n = list.First();
                    }
                    l = n + i;
                    bool x = list.Remove(l);
                    Console.Write($"{l},");
                    if (x == false)
                    {
                        return false;
                    }
                }

                Console.WriteLine();
            }

            if (list.Count > 0)
                return false;
            else
                return true;
        }

        static bool IsConsecutive(int[] nums, int start, int length)
        {

            return false;
        }
    }
}
