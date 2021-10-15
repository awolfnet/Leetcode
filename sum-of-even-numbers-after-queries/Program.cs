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

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            int[] result = SumEvenAfterQueries(nums, queries);

            stopwatch.Stop();

            foreach (int v in result)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }

        static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            int sumeven = SumEvenArray(nums);

            List<int> list = new List<int>();
            foreach (int[] query in queries)
            {
                int index = query[1];
                int value = query[0];
                int oldnum = nums[index];
                nums[index] += value;

                if (IsEven(oldnum))
                {
                    if (IsEven(value))
                    {
                        sumeven += value;
                    }
                    else
                    {
                        sumeven -= oldnum;
                    }
                }
                else
                {
                    if (IsEven(value) == false)
                    {
                        sumeven += nums[index];
                    }
                    else
                    {

                    }

                }

                list.Add(sumeven);
            }
            return list.ToArray();
        }

        static int SumEvenArray(int[] nums)
        {
            int sum = 0;
            foreach (int v in nums)
            {
                if (v % 2 == 0)
                {
                    sum += v;
                }
            }
            return sum;
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
