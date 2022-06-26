using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "gfkahldcjebi";
            int[] sorted;
            bool b = Sort3(s,out sorted);


            Console.ReadKey();
        }

        public static bool Sort3(string s, out int[] sorted)
        {
            char[] array = s.ToCharArray();
            int length = s.Length;
            bool IsSorted = false;
            sorted = new int[length];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {

                    if (array[i] > array[j])
                    {
                        char c = array[i];
                        array[i] = array[j];
                        array[j] = c;
                        IsSorted = true;
                    }
                }
                sorted[i] = array[i];
            }

            return IsSorted;
        }

        public static bool Sort2(ref int[] array)
        {
            bool sorted = false;
            int length = array.Length;
            for(int i=0;i< length; i++)
            {
                for(int j=i+1;j< length; j++)
                {
                    if(array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                        sorted = true;
                    }
                }
            }

            return sorted;
        }

        public static void Sort(int[] num)
        {
            int length = num.Length;
            for (int i = 0; i < length; i++)
            {
                int ori = num[i];
                int j = i;
                while (j > 0 && num[j - 1] > ori)
                {
                    num[j] = num[j - 1];
                    j--;
                }
                num[j] = ori;
            }

        }
    }
}
