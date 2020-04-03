using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }

            var strN = n.ToString();
            var result = 0;
            var resultsDict = new Dictionary<int, int>();

            while (result >= 0)
            {
                foreach (var charN in strN)
               { 
                   var nVal = (charN - '0') * (charN - '0'); 
                   result += nVal;
               }
                
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    if (resultsDict.ContainsKey(result))
                    {
                        return false;
                    }
                    else
                    {
                        resultsDict.Add(result, 1);
                        strN = result.ToString();
                        result = 0;
                    }
                }
            }

            return false;
        }
    }
}