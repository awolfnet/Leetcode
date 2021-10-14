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
            int num = 5;
            Console.WriteLine(FindComplement(num));
            Console.ReadKey();
        }

        static int FindComplement(int num)
        {
            byte[] bin = Dec2Bin(num);

            List<byte> target = new List<byte>();
            foreach (byte b in bin)
            {
                target.Add((byte)(b ^ 1));
            }

            int r = Bin2Dec(target.ToArray());
            return r;
        }
        static byte[] Dec2Bin(int num)
        {
            List<byte> list = new List<byte>();
            int mod = 0;
            while (num >= 1)
            {
                mod = num % 2;
                num = num / 2;
                list.Add(Convert.ToByte(mod));
            }
            list.Reverse();
            return list.ToArray();
        }

        static int Bin2Dec(byte[] num)
        {
            int power = num.Length;
            int r = 0;
            foreach (byte b in num)
            {
                power--;
                r += b * (int)Math.Pow(2, power);
            }
            return r;
        }

    }
}
