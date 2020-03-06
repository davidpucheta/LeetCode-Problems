using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class IsPalindrome
    {
        public bool checkPalindrome(string inputString)
        {
            var toReturn = false;

            if (String.IsNullOrEmpty(inputString))
            {
                return toReturn;
            }

            var originalStr = inputString.Replace(" ", "").ToLower().Trim();
            var reversedStr = originalStr.ToCharArray();
            Array.Reverse(reversedStr);

            for (int i = 0; i < originalStr.Length; i++)
            {
                if (originalStr[i] == reversedStr[i])
                {
                    toReturn = true;
                }
                else
                {
                    return false;
                }
            }

            return toReturn;
        }

    }
}
