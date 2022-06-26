using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_and_replace_pattern
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] words = { "abc", "deq", "mee", "aqq", "dkd", "ccc", "abc", "cba", "xyx", "yxx", "yyx" };
            string pattern = "abc";

            IList<string> result = FindAndReplacePattern(words, pattern);

            foreach (string val in result)
            {
                Console.Write($"{val},");
            }
            Console.ReadKey();
        }

        static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> result = new List<string>();
            char[] p = pattern.ToCharArray();
            int[] v = new int[p.Length - 1];

            if (p.Length == 1)
            {
                foreach (string w in words)
                {
                    if (w.Length == 1)
                    {
                        result.Add(w);
                    }
                }

                return result;
            }


            for (int j = 0; j < p.Length - 1; j++)
            {
                v[j] = Math.Abs(p[j + 1] - p[j]) == 0 ? 0 : 1;
            }


            foreach (string w in words)
            {
                char[] wd = w.ToCharArray();
                bool match = true;
                for (int j = 0; j < wd.Length - 1; j++)
                {
                    int r = Math.Abs(wd[j + 1] - wd[j]) == 0 ? 0 : 1;
                    if (r != v[j])
                    {
                        match &= false;
                        break;
                    }
                    else
                    {
                        match &= true;
                    }

                }

                if (match == true)
                {
                    result.Add(w);
                }

            }
            return result;
        }
        static int[] Difference(string word)
        {
            char[] p = word.ToCharArray();
            int length = p.Length;
            int[] d = new int[length - 1];

            for (int j = 0; j < length - 1; j++)
            {
                d[j] = Math.Abs(p[j + 1] - p[j]) == 0 ? 0 : 1;
            }



            return d;
        }
    }
}
