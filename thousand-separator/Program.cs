using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_separator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThousandSeparator(1234567));
            Console.ReadKey();
        }

        static string ThousandSeparator(int n)
        {
            string input = n.ToString();
            int l = input.Length;

            if (l <= 3)
            {
                return input;
            }

            int j = l % 3;
            l = j > 0 ? l + 3 - j : l + j;

            input = n.ToString().PadLeft(l, ' ');

            string result = string.Empty;

            for (int i = 0; i < l; i += 3)
            {
                result+=(input.Substring(i, 3));
                result+=(".");
            }

            result = result.Trim();
            return result.Substring(0,result.Length-1);
        }
    }
}
