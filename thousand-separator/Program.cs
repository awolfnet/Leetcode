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
            Console.WriteLine(ThousandSeparator(1234567890));
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

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < l; i += 3)
            {
                sb.Append(input.Substring(i, 3));
                sb.Append(".");
            }
            sb.Remove(sb.Length - 1, 1);

            string result = sb.ToString().Trim();
            return result;
        }
    }
}
