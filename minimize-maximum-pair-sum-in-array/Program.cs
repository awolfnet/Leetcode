using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimize_maximum_pair_sum_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 5, 2, 3 };
            Console.WriteLine(MinPairSum(nums));
            Console.ReadKey();
        }

        static int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            int l = nums.Length;
            int c = l / 2;
            int result = 0;

            for (int i = 0; i < c; i++)
            {
                int r = nums[i] + nums[l - 1 - i];
                result = Math.Max(result, r);
            }


            return result;
        }
    }
}
