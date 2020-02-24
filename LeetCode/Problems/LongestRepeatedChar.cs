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

            foreach (var item in text)
            {
                dic[item] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                var currectChar = text[i];
                var swapChar = text[i];

                for (int j = 0; j < text.Length; j++)
                {
                    swapChar = text[j];
                    var newText = new StringBuilder(text);
                    newText[i] = swapChar;
                    newText[j] = currectChar;
                    var count = 0; 

                    for (int k = 0; k < newText.Length; k++)
                    {
                         
                        if (newText[k] == currectChar)
                        {
                            count += 1;
                            dic[currectChar] = count > dic[currectChar] ? count : dic[currectChar];   
                        } 
                        else
                        {
                            count = 0;
                        }
                    }
                }
            }

            foreach (var item in dic)
            {
                toReturn = item.Value > toReturn? item.Value : toReturn;
            }

            return toReturn;
        }
    }
}
