using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems
{
    class CtorNames
    {
        public bool constructorNames(string className, string methodName)
        {
            var toReturn = false;

            if (String.IsNullOrEmpty(className) || String.IsNullOrEmpty(methodName))
            {
                return toReturn;
            }

            var s0 = new Dictionary<char, int>();
            var s1 = new Dictionary<char, int>();

            foreach (var chr in className)
            {
                if (s0.ContainsKey(chr))
                {
                    s0[chr] += 1;
                }
                else
                {
                    s0.Add(chr, 1);
                }
            }

            foreach (var chr in methodName)
            {
                if (s1.ContainsKey(chr))
                {
                    s1[chr] += 1;
                }
                else
                {
                    s1.Add(chr, 1);
                }
            }

            var lst0 = s0.OrderBy( x => x.Value).ToList();
            var lst1 = s1.OrderBy(x => x.Value).ToList();

            for (int i = 0; i < lst0.Count; i++)
            {
                if (lst0[i].Value == lst1[i].Value
                    && s0.ContainsKey(lst1[i].Key))
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
