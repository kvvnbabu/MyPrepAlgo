using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Strings
{
    public class PatternNaiveAlgo
    {
        public int[] SearchPattern(string str, string pattern)
        {
            if (str == null || str.Length == 0 || pattern == null || pattern.Length == 0)
                return new int[0];
            int m = str.Length;
            int n = pattern.Length;
            int maxFindingLoacations = m - n + 1;

            if (maxFindingLoacations < 1) return new int[0];

            int[] matches = new int[maxFindingLoacations];
            for (int i = 0; i < maxFindingLoacations; i++) matches[i] = -1;

            int matchCount = 0;
            for (int i = 0; i < maxFindingLoacations; i++)
            {
                int j = 0;
                for (; j < n; j++)
                {
                    if (str[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == n)
                    matches[matchCount++] = i;

                //if(str[i] == pattern[0])
                //{
                //    isPatternMatched = true;
                //    for (int j = 1; j<pattern.Length; j++)
                //    {
                //        if(str[i+j] != pattern[j])
                //        {
                //            isPatternMatched = false;
                //            break;
                //        }
                //    }
                //    if (isPatternMatched)
                //        matches[matchCount++] = i;
                //}
            }

            int[] result = new int[matchCount];
            for (int i = 0; i < matchCount; i++) result[i] = matches[i];

            return result;
        }
    }
}
