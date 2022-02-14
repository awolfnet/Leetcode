using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_product_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2 };
            Console.WriteLine(MaxProduct(nums));
            Console.ReadKey();
        }

        static int MaxProduct(int[] nums)
        {
            int l = nums.Length;

            int result = 0;

            for (int i = 0; i < l; i++)
            {
                int r = nums[i];
                for(int j=i+1;j<l;j++)
                {
                    r *= nums[j];
                    result = Math.Max(result, r);
                }
                
            }


            return result;
        }
    }
}
