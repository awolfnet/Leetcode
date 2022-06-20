using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace push_dominoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dominoes = ".L.R...LR..L..";

            string result = PushDominoes(dominoes);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string PushDominoes(string dominoes)
        {
            char[] result = dominoes.ToCharArray();
            int[] actions = new int[result.Length];

            int i = 0;

            foreach (char d in dominoes)
            {
                if (d == 'L' || d == 'R')
                {
                    actions[i] = 0;
                }
                else
                {
                    actions[i] = 1;
                }
                i++;
            }






            return new string(result);
        }
    }
}
