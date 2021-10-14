using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_complement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            Console.WriteLine(FindComplement(num));
            Console.ReadKey();
        }

        static int FindComplement(int num)
        {
            List<bool> bin = Dec2Bin(num);

            List<bool> target = new List<bool>();
            foreach (bool b in bin)
            {
                target.Add(!b);
            }

            int r = Bin2Dec(target);
            return r;
        }
        static List<bool> Dec2Bin(int num)
        {
            List<bool> list = new List<bool>();
            int mod = 0;
            while (num >= 1)
            {
                mod = num % 2;
                num = num / 2;
                list.Add(Convert.ToBoolean(mod));
            }
            list.Reverse();
            return list;
        }

        static int Bin2Dec(List<bool> num)
        {
            int power = num.Count;
            int r = 0;
            foreach(bool b in num)
            {
                power--;
                r += Convert.ToInt32(b) * (int)Math.Pow(2, power);
            }
            return r;
        }

    }
}
