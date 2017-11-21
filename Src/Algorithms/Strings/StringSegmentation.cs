using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class StringSegmentation
    {
        /*
         * https://www.careercup.com/question?id=5718859091804160
         * given a string and a segmentation length k 
         * For example: 
         * "This is a good day" k = 10 
         * Cut into: 
         * "This (1/4)" 
         * "is a (2/4)" 
         * "good (3/4)" 
         * "day (4/4)" 
         * Each line followed by a suffix in the form of (i/n) has 10 chars including space (except for the last line), return the minimum cut required, for the example, just return 4.
         * */
        public int GetMinSegmentCuts1(string txt, int k)
        {
            int len = txt.Length;
            int segDigits = 1;
            while (true)
            {
                int maxLen = 0;
                int multiplier = 9;
                int segCount = 0;
                int suffixSize = 0;

                for (int i = 1; i <= segDigits; i++)
                {
                    suffixSize = 3 + segDigits + i;
                    if (suffixSize == k) return 0;
                    maxLen += (k - suffixSize) * multiplier;
                    segCount += multiplier;
                    multiplier *= 10;
                }
                segDigits++;

                if (len <= maxLen)
                {
                    segCount -= (maxLen - len) / (k - suffixSize);
                    return segCount;
                }
            }
        }

        public int GetMinSegmentCuts(string txt, int k)
        {
            int len = txt.Length;

            int suffixMinLen = k - 5; // 5 - for (_/_)
            if (suffixMinLen <= 0) return 0;
            int maxSegCount = (int)Math.Ceiling((double)len / suffixMinLen);

            int digits = 0;
            int t = maxSegCount;
            while (t > 0)
            {
                digits++;
                t = t / 10;
            }


            int suffixLen = 0;
            int maxLen = 0;
            int segsByLength = 9;
            int segCount = 0;
            for (int i = 1; i <= digits; i++)
            {
                suffixLen = 3 + i + digits;
                if (suffixLen == k) return 0;
                segCount += segsByLength;
                maxLen += segsByLength * (k - suffixLen);
                segsByLength *= 10;
            }

            return segCount - ((maxLen - len) / (k - suffixLen));
        }
    }
}
