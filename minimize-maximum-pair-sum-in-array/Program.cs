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
            int[] nums = {3,5,4,2,4,6 };
            Console.WriteLine(MinPairSum(nums));
            Console.ReadKey();
        }

        static int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {

            }

            return 0;
        }
    }
}
