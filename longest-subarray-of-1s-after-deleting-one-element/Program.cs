using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_subarray_of_1s_after_deleting_one_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubarray(new int[] { 1, 1, 0, 0, 1, 1, 1, 0, 1 }));

        }

        static int LongestSubarray(int[] nums)
        {
            FindLongest(nums);
            return 0;
        }

        static List<int> ElementCanBeDeleted(int[] nums)
        {
            List<int> list = new List<int>();
            for(int i=1;i<nums.Length-2;i++)
            {
                int prev = nums[i - 1];
                int curr = nums[i];
                int next = nums[i + 1];

                if(prev==1 && curr ==0 && next ==1)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        static int FindLongest(int[] nums)
        {
            int max = 0;
            for(int i=0;i<nums.Length-1;i++)
            {
                if(nums[i]==1)
                {
                    int j = i;
                    for(j=i;j<nums.Length-1;j++)
                    {
                        if(nums[j]==0)
                        {
                            break;
                        }
                    }

                    int c = j - i;
                    if(c>max)
                    {
                        max = c;
                    }
                }
            }

            return max;
        }
    }
}
