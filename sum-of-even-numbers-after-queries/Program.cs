using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_even_numbers_after_queries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[][] queries = new int[4][];
            queries[0] = new int[] { 1, 0 };
            queries[1] = new int[] { -3, 1 };
            queries[2] = new int[] { -4, 0 };
            queries[3] = new int[] { 2, 3 };

            int[] result = SumEvenAfterQueries(nums, queries);
            foreach(int v in result)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }

        static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            List<int> list = new List<int>();
            foreach(int[] query in queries)
            {
                int index = query[1];
                int value = query[0];

                nums[index] += value;

                list.Add(SumEvenArray(nums));
            }
            return list.ToArray();
        }

        static int SumEvenArray(int[] nums)
        {
            int sum = 0;
            foreach(int v in nums)
            {
                if(v%2==0)
                {
                    sum += v;
                }
            }
            return sum;
        }
    }
}
