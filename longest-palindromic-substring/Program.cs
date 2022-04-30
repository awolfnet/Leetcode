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
            string s = "babadbbabaabababbaababa";
            string s1 = "a";
            string s2 = "aa";
            string s3 = "rgczcpratwyqxaszbuwwcadruayhasynuxnakpmsyhxzlnxmdtsqqlmwnbxvmgvllafrpmlfuqpbhjddmhmbcgmlyeypkfpreddyencsdmgxysctpubvgeedhurvizgqxclhpfrvxggrowaynrtuwvvvwnqlowdihtrdzjffrgoeqivnprdnpvfjuhycpfydjcpfcnkpyujljiesmuxhtizzvwhvpqylvcirwqsmpptyhcqybstsfgjadicwzycswwmpluvzqdvnhkcofptqrzgjqtbvbdxylrylinspncrkxclykccbwridpqckstxdjawvziucrswpsfmisqiozworibeycuarcidbljslwbalcemgymnsxfziattdylrulwrybzztoxhevsdnvvljfzzrgcmagshucoalfiuapgzpqgjjgqsmcvtdsvehewrvtkeqwgmatqdpwlayjcxcavjmgpdyklrjcqvxjqbjucfubgmgpkfdxznkhcejscymuildfnuxwmuklntnyycdcscioimenaeohgpbcpogyifcsatfxeslstkjclauqmywacizyapxlgtcchlxkvygzeucwalhvhbwkvbceqajstxzzppcxoanhyfkgwaelsfdeeviqogjpresnoacegfeejyychabkhszcokdxpaqrprwfdahjqkfptwpeykgumyemgkccynxuvbdpjlrbgqtcqulxodurugofuwzudnhgxdrbbxtrvdnlodyhsifvyspejenpdckevzqrexplpcqtwtxlimfrsjumiygqeemhihcxyngsemcolrnlyhqlbqbcestadoxtrdvcgucntjnfavylip";

            string result = LongestPalindrome(s);
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
                for (int j = longest; j < l - i + 1; j++)
                {
                    string word = s.Substring(i, j);
                    Console.WriteLine($"Word: {word}");

                    if(j<=1)
                    {
                        longest = j;
                        result = word;
                        continue;
                    }

                    int m = j / 2;
                    int n = j % 2;

                    string wordleft = word.Substring(0, m);
                    string wordright = string.Empty;

                    for (int idx = j - 1; idx >= m + n; idx--)
                    {
                        wordright += word.Substring(idx, 1);
                    }

                    if (wordleft.Equals(wordright))
                    {
                        longest = j;
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

            string wordleft = s.Substring(0, m);
            string wordright = string.Empty;

            for (int i = l - 1; i >= m + n; i--)
            {
                wordright += s.Substring(i, 1);
            }

            if (wordleft.Equals(wordright))
            {
                //Console.WriteLine(s);
                return l;
            }
            else
            {
                return 0;
            }
        }
    }
}
