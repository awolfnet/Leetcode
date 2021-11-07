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
        }

        static string ThousandSeparator(int n)
        {
            string input = n.ToString();
            int l = input.Length;

            if (l <= 3)
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();

            int j = 3 - l % 3;

            if(j==3)
            {
                j = 0;
            }else
            {
                for (int i = 0; i < j; i++)
                {
                    sb.Append("0");
                }
            }

            sb.Append(input);

            input = sb.ToString();
            sb.Clear();

            for (int i = 0; i < l + j; i += 3)
            {
                sb.Append(input.Substring(i, 3));
                sb.Append(".");
            }
            sb.Remove(sb.Length - 1, 1);


            string result = sb.ToString();
            return result.Substring(j);
        }
    }
}
