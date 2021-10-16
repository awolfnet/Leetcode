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
            int[] ratings = new int[] { 1, 2, 87, 87, 87, 2, 1 };

            Console.WriteLine(Candy(ratings));
            Console.ReadKey();
        }

        static int Candy(int[] ratings)
        {
            int minimum = ratings.Length;
            int lastCandy = 1;

            bool Added = false;

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
                    Added = true;
                }
                else if (c < prev)
                {
                    lastCandy++;
                    Added = false;
                }
                else if (c == prev)
                {
                    lastCandy = 1;
                }

                //[1,2,87,87,87,2,1]
                // 1,2,3 ,1 ,3 ,2,1

                //9,8,7,7,6,5,5,4,3,2,1
                //1,1,1,1,1,1,1,1,1,1,1 =11
                //3,2,1,3,2,1,5,4,3,2,1

                //1,2,3,4,5,4,3,2,1
                //1,2,3,4,5,

                //1,2,3,4,5,5,4,3,2,1
                //1,2,3,4,5,
            }

            if(Added==false)
            {
                minimum += lastCandy;
            }

            return minimum;
        }
    }
}
