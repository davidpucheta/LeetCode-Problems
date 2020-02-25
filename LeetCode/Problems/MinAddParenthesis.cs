using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class MinAddParenthesis
    {
        public int MinAddToMakeValid(string S)
        {
            if (String.IsNullOrEmpty(S))
            {
                return 0;
            }

            var pairCount = 0;
            var openingChar = 0;

            foreach (var item in S)
            {
                if (item == '(')
                {
                    openingChar++;  
                }
                else
                {
                    if (openingChar > 0)
                    {
                        pairCount += 2;
                        openingChar--;
                    }
                }
            }

            return S.Length - pairCount;
        }
    }
}
