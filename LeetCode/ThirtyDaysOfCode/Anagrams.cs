using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }
            
            var dict = new Dictionary<string, IList<string>>();
    
            foreach (var str in strs)
            {
                var charArr = str.ToCharArray();
                Array.Sort(charArr);
                var tempStr = new string(charArr);

                if (dict.ContainsKey(tempStr))
                {
                    dict[tempStr].Add(str); 
                }
                else
                {
                    var tmpList = new List<string> {str};
                    dict.Add(tempStr,tmpList);
                }
            }

            return new List<IList<string>>(dict.Values);
        }
    }
}