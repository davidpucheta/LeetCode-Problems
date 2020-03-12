using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetCode.Problems
{
    public class RemoveKDigits
    {
        public string RemoveKdigits(string num, int k)
        {
            var numLength = num.Length;
            
            if (string.IsNullOrEmpty(num)
                || numLength == k )
            {
                return "0";    
            }

            var charStack = new Stack<char>();
            var i = 0;

            while (i < numLength)
            {
                while (k > 0 
                       && charStack.Count > 0 
                       && charStack.Peek() > num[i])
                {
                    charStack.Pop();
                    k--;
                }
                
                charStack.Push(num[i]);
                i++;
            }

            while (k > 0)
            {
                charStack.Pop();
                k--;
            }

            var toReturn = "";

            while (charStack.Count > 0)
            {
                var currentChar = charStack.Pop();
                toReturn = currentChar + toReturn;
            }

            while (toReturn.Length > 1 && toReturn[0] == '0')
            {
                toReturn = toReturn.Substring(1);
            }

            return toReturn;
        }
    }
}