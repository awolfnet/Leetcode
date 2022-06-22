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
            string[] words = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            string pattern = "abb";

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
                v[j] = (p[j + 1] - p[j]) == 0 ? 0 : 1;
            }


            foreach (string w in words)
            {
                char[] wd = w.ToCharArray();
                bool match = true;
                for (int j = 0; j < wd.Length - 1; j++)
                {
                    int r = (wd[j + 1] - wd[j]) == 0 ? 0 : 1;
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
    }
}
