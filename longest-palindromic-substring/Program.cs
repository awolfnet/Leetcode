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
            string s1 = "a";
            string s2 = "aa";
            string s3 = "zudfweormatjycujjirzjpyrmaxurectxrtqedmmgergwdvjmjtstdhcihacqnothgttgqfywcpgnuvwglvfiuxteopoyizgehkwuvvkqxbnufkcbodlhdmbqyghkojrgokpwdhtdrwmvdegwycecrgjvuexlguayzcammupgeskrvpthrmwqaqsdcgycdupykppiyhwzwcplivjnnvwhqkkxildtyjltklcokcrgqnnwzzeuqioyahqpuskkpbxhvzvqyhlegmoviogzwuiqahiouhnecjwysmtarjjdjqdrkljawzasriouuiqkcwwqsxifbndjmyprdozhwaoibpqrthpcjphgsfbeqrqqoqiqqdicvybzxhklehzzapbvcyleljawowluqgxxwlrymzojshlwkmzwpixgfjljkmwdtjeabgyrpbqyyykmoaqdambpkyyvukalbrzoyoufjqeftniddsfqnilxlplselqatdgjziphvrbokofvuerpsvqmzakbyzxtxvyanvjpfyvyiivqusfrsufjanmfibgrkwtiuoykiavpbqeyfsuteuxxjiyxvlvgmehycdvxdorpepmsinvmyzeqeiikajopqedyopirmhymozernxzaueljjrhcsofwyddkpnvcvzixdjknikyhzmstvbducjcoyoeoaqruuewclzqqqxzpgykrkygxnmlsrjudoaejxkipkgmcoqtxhelvsizgdwdyjwuumazxfstoaxeqqxoqezakdqjwpkrbldpcbbxexquqrznavcrprnydufsidakvrpuzgfisdxreldbqfizngtrilnbqboxwmwienlkmmiuifrvytukcqcpeqdwwucymgvyrektsnfijdcdoawbcwkkjkqwzffnuqituihjaklvthulmcjrhqcyzvekzqlxgddjoir";

            string result = LongestPalindrome(s3);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static string LongestPalindrome(string s)
        {
            int l = s.Length;
            int longest = 0;

            string result = string.Empty;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - i + 1; j++)
                {
                    string word = s.Substring(i, j);
                    int lng = IsPalindrome(word);
                    if (lng > longest)
                    {
                        longest = lng;
                        result = word;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Length of a palindrome string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int IsPalindrome(string s)
        {
            int l = s.Length;
            if (l <= 1)
            {
                return l;
            }

            int m = l / 2;
            int n = l % 2;

            string wordleft = string.Empty;
            string wordright = string.Empty;

            if (n == 0)
            {
                wordleft = s.Substring(0, m);
                wordright = s.Substring(m, l - m);
            }
            else
            {
                wordleft = s.Substring(0, m);
                wordright = s.Substring(m + 1, l - m - 1);
            }

            string wordrightReversed = new string(wordright.Reverse().ToArray());
            
            if(wordleft.Equals(wordrightReversed))
            {
                //Console.WriteLine(s);
                return l;
            }else
            {
                return 0;
            }
        }
    }
}
