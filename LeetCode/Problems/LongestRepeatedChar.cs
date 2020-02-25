using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class LongestRepeatedChar
    {
        public int MaxRepOpt1(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return 0;
            }

            var dic = new Dictionary<char, int>();
            var toReturn = 0;
            var currectChar = ' ';
            var count = 0;

            foreach (var item in text)
            {
                dic[item] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];


                if (currectChar == c)
                {
                    count += 1;
                } 
                else
                {
                    currectChar = c;
                    count = 1;
                }

                dic[c] = count > dic[c] ? count : dic[c];
            }
           

            foreach (var item in dic)
            {
                toReturn = item.Value > toReturn? item.Value : toReturn;
            }

            return toReturn;
        }
    }
}
