using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class UniqueSubstrings
    {
        public int FindSubstringInWraproundString(string p)
        {
            if (String.IsNullOrEmpty(p))
            {
                return 0;
            }

            var count = new int[26];
            var result = 0;
            var maxSize = 1;
            count[p[0] - 'a'] = 1;

            for (int i = 1; i < p.Length; i++)
            {
                var curChar = p[i];
                var prevChar = p[i - 1];
                var curVal = curChar + 0;
                var prevVal = prevChar + 1;

                if (curVal == prevVal || prevChar == 'z' && curChar == 'a')
                {
                    maxSize++;
                }
                else
                {
                    maxSize = 1;
                }

                count[curChar - 'a'] = Math.Max(count[curChar - 'a'], maxSize);
            }

            foreach (var item in count)
            {
                result += item;
            }

            return result;
        }
    }
}


/* 467. Unique Substrings in Wraparound String
 Consider the string s to be the infinite wraparound string of "abcdefghijklmnopqrstuvwxyz", so s will look like this: "...zabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd....".

Now we have another string p. Your job is to find out how many unique non-empty substrings of p are present in s. In particular, your input is the string p and you need to output the number of different non-empty substrings of p in the string s.

Note: p consists of only lowercase English letters and the size of p might be over 10000.
 */
