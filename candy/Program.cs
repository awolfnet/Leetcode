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
            int[] ratings1 = new int[] { 1,0,2 };
            int[] ratings2 = new int[] { 1,2,2 };
            int[] ratings3 = new int[] { 1, 2, 87, 87, 87, 2, 1 };
            int[] ratings4 = new int[] { 1, 3, 2, 2, 1 };

            int[] ratings99 = new int[] { 9, 8, 7, 7, 6, 5, 5, 4, 3, 2, 1 };

            Console.WriteLine($"5:{Candy(ratings1)}");
            Console.WriteLine($"4:{Candy(ratings2)}");
            Console.WriteLine($"13:{Candy(ratings3)}");
            Console.WriteLine($"7:{Candy(ratings4)}");
            Console.WriteLine($"27:{Candy(ratings99)}");

            Console.ReadKey();
        }

        static int Candy(int[] ratings)
        {
            int minimum = 1;
            int candy = 1;
            bool up = false;
            bool down = false;
            Console.Write("1,");

            for (int i = 1; i < ratings.Length; i++)
            {
                int prev = ratings[i - 1];
                //int next = i == ratings.Length - 1 ? 0 : ratings[i + 1];
                int c = ratings[i];

                if (c > prev)
                {
                    if(down)
                    {
                        candy = 1;
                        down = false;
                    }
                    candy++;
                    up = true;
                }
                else if (c < prev)
                {
                    if(up)
                    {
                        candy = 1;
                        up = false;
                    }
                    candy++;
                    down = true;
                }
                else if (c == prev)
                {
                    candy = 1;
                }
                minimum += candy;

                Console.Write($"{candy},");

                //[1,3,2,2,1]
                // 1,2,1,2,1
                // 1,2,1,1,2

                //[1,2,87,87,87,2,1]
                // 1,2,3 ,1 ,3 ,2,1

                //9,8,7,7,6,5,5,4,3,2,1
                //1,1,1,1,1,1,1,1,1,1,1 =11
                //3,2,1,3,2,1,5,4,3,2,1

                //1,2,3,4,5,4,3,2,1
                //1,2,3,4,5,

                //1,2,3,4,5,5,4,3,2,1
                //1,2,3,4,5,

                //1,2,3,4,3,2,1,2,3,4
                //

                //1,2,3,1,2,3
                
            }
            Console.WriteLine();
            return minimum;
        }
    }
}
