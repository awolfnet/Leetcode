using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_palindromic_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";

            string result = LongestPalindrome(s);

            Console.ReadKey();
        }

        public static string LongestPalindrome(string s)
        {
            int l = s.Length;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - i+1; j++)
                {
                    Console.WriteLine(s.Substring(i, j));
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Length of a palindrome string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int IsPalindrome(string s)
        {

            return 2;
        }
    }
}
