using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ratings = new int[] { 1, 2, 2 };

            Console.WriteLine(Candy(ratings));
            Console.ReadKey();
        }

        static int Candy(int[] ratings)
        {
            int minimum = ratings.Length;
            int lastCandy = 1;

            if (ratings[0] > ratings[1])
            {
                minimum++;
                lastCandy++;
            }

            for (int i = 1; i < ratings.Length; i++)
            {
                int prev = ratings[i - 1];
                //int next = i == ratings.Length - 1 ? 0 : ratings[i + 1];
                int c = ratings[i];

                if (c > prev)
                {
                    minimum += lastCandy;
                    lastCandy++;
                }
                else
                {
                    lastCandy = 1;
                }

                //1,2,5,8,9,6,3
                //1,2,3,4,5,1,2

            }
            return minimum;
        }
    }
}
