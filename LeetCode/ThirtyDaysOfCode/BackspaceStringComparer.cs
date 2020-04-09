using System.Collections;
using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class BackspaceStringComparer
    {
        public bool BackspaceCompare(string S, string T)
        {
            if (S == T)
            {
                return true;
            }
            
            var sChars = new Stack<char>();
            var tChars = new Stack<char>();

            foreach (var ch in S)
            {
                if (ch != '#')
                {
                    sChars.Push(ch);
                }
                else if (sChars.Count > 0)
                { 
                    sChars.Pop();
                }
                
            }
            
            foreach (var ch in T)
            {
                if (ch != '#')
                {
                    tChars.Push(ch);
                }
                else if (tChars.Count > 0)
                { 
                    tChars.Pop();
                }
                
            }

            while (sChars.Count > 0)
            {
                var top = sChars.Pop();
                if (tChars.Count == 0 || tChars.Pop() != top)
                {
                    return false;
                }
            }

            return sChars.Count == 0 && tChars.Count == 0;
        }
        
    }
}