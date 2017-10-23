using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Strings
{
    public class PatternKMSAlog
    {
        public int[] SearchPattern(string str, string pattern)
        {
            if (str == null || pattern == null) return new int[0];

            int m = pattern.Length;
            int n = str.Length;

            if (m == 0 || n == 0 || m > n) return new int[0];

            int[] lps = GetLPS(pattern);

            int[] matches = new int[n - m + 1];
            for (int itr = 0; itr < matches.Length; itr++) matches[itr] = -1;

            int found = 0;

            int i = 0, j = 0;

            while (i < n)
            {
                if (str[i] == pattern[j])
                {
                    i++;
                    j++;
                }

                if (j == m)
                {
                    matches[found++] = i - m;
                    j = lps[j - 1];
                }
                else if (i < n && str[i] != pattern[j])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            int[] result = new int[found];
            for (int x = 0; x < found; x++) result[x] = matches[x];

            return result;

        }

        public int[] GetLPS(string pattern)
        {
            int m = pattern.Length;
            int[] result = new int[m];

            int i = 1;
            int len = 0;
            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    result[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = result[len - 1];
                    }    
                    else
                    {
                        result[i] = 0;
                        i++;
                    }
                }
            }

            return result;
        }
    }
}
