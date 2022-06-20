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
            string dominoes = ".L.R...LR..L........LR";

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

            int length = dominoes.Length;

            Console.WriteLine(new string(result));
            foreach (int a in actions)
            {
                Console.Write(a);
            }

            Console.WriteLine();
            Console.WriteLine();

            while (!done(actions))
            {
                char[] dmove = new char[result.Length];
                result.CopyTo(dmove, 0);

                int[] dactions = new int[actions.Length];
                actions.CopyTo(dactions, 0);

                //Left to right
                for (i = 0; i < length; i++)
                {
                    char d = result[i];

                    if (d == 'R')
                    {
                        //next
                        int inext = i + 1;
                        if (inext < length)
                        {
                            int a = actions[inext];
                            if (a == 1)
                            {
                                if (inext + 1 >= length)
                                {
                                    dmove[inext] = 'R';
                                }
                                else
                                {
                                    char dnext = result[inext + 1];
                                    if(dnext!='L')
                                    {
                                        dmove[inext] = 'R';
                                    }
                                    
                                }
                                dactions[inext] = 0;
                            }
                        }
                    }
                }

                //Right to left
                for (i = length - 1; i >= 0; i--)
                {
                    char d = result[i];

                    if (d == 'L')
                    {
                        //next
                        int inext = i - 1;
                        if (inext >= 0)
                        {
                            int a = actions[inext];
                            if (a == 1)
                            {
                                if (inext - 1 < 0)
                                {
                                    dmove[inext] = 'L';
                                }
                                else
                                {
                                    char dnext = result[inext - 1];
                                    if (dnext != 'R')
                                    {
                                        dmove[inext] = 'L';
                                    }

                                }
                                dactions[inext] = 0;
                            }
                        }

                    }
                }

                //for (i = 0; i < length; i++)
                //{
                //    int action = actions[i];
                //    int actleft = i >= 1 ? actions[i - 1] : 0;
                //    int actright = i < length - 1 ? actions[i + 1] : 0;

                //    if (action == 1 && (actleft != 1 || actright != 1))
                //    {
                //        char left = i >= 1 ? result[i - 1] : '.';
                //        char right = i < length - 1 ? result[i + 1] : '.';
                //        char d = move(left, right);
                //        Console.WriteLine($"{i}:{left}_{result[i]}_{right} -- {d}");
                //        dmove[i] = d;
                //        dactions[i] = 0;
                //    }
                //}

                dmove.CopyTo(result, 0);
                dactions.CopyTo(actions, 0);
                Console.WriteLine(new string(result));
                foreach (int a in actions)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                Console.ReadKey();
            }

            //Console.WriteLine(new string(result));
            //char[] dmove = result;
            //int[] dactions = actions;

            //for (i = 0; i < length; i++)
            //{
            //    int action = actions[i];
            //    if (action == 1)
            //    {
            //        char dRight = '.', dLeft = '.';
            //        if (i == 0)
            //        {
            //            dRight = result[i + 1];
            //        }
            //        else if (i == length - 1)
            //        {
            //            dLeft = result[i - 1];
            //        }
            //        else
            //        {
            //            dRight = result[i + 1];
            //            dLeft = result[i - 1];
            //        }

            //        if (dLeft == '.' && dRight == 'L')   //..L
            //        {
            //            dmove[i] = 'L';
            //        }
            //        else if (dLeft == '.' && dRight == 'R') //..R
            //        {

            //        }
            //        else if (dLeft == 'L' && dRight == '.') //L..
            //        {

            //        }
            //        else if (dLeft == 'R' && dRight == '.') //R..
            //        {
            //            dmove[i] = 'R';
            //        }
            //        else if (dLeft == 'L' && dRight == 'L')    //L.L
            //        {
            //            dmove[i] = 'L';
            //        }
            //        else if (dLeft == 'R' && dRight == 'R')    //R.R
            //        {
            //            dmove[i] = 'R';
            //        }
            //        else if (dLeft == 'R' && dRight == '.')    //L.R
            //        {

            //        }
            //        else if (dLeft == 'R' && dRight == '.')    //R.L
            //        {

            //        }


            //        Console.WriteLine(new string(dmove));
            //        foreach (int a in actions)
            //        {
            //            Console.Write(a);
            //        }


            //        dactions[i] = 0;

            //        Console.WriteLine();
            //        Console.ReadKey();
            //    }

            //}
            //result = dmove;
            //actions = dactions;



            return new string(result);
        }

        static bool done(int[] action)
        {
            int r = 0;
            foreach (int i in action)
            {
                r += i;
            }

            if (r == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static char move(char left, char right)
        {
            char result = '.';

            if (left == '.' && right == 'L')   //..L
            {
                result = 'L';
            }
            else if (left == '.' && right == 'R') //..R
            {

            }
            else if (left == 'L' && right == '.') //L..
            {

            }
            else if (left == 'R' && right == '.') //R..
            {
                result = 'R';
            }
            else if (left == 'L' && right == 'L')    //L.L
            {
                result = 'L';
            }
            else if (left == 'R' && right == 'R')    //R.R
            {
                result = 'R';
            }
            else if (left == 'R' && right == '.')    //L.R
            {

            }
            else if (left == 'R' && right == '.')    //R.L
            {

            }

            return result;
        }
    }
}
