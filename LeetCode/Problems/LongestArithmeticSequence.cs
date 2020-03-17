using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class LongestArithmeticSequence
    {
        public int LongestArithSeqLength(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            var longestSeq = 0;
            var subSeqs = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length - 1; j++)
                {
                    var temp = A[j + 1] - A[i];

                    if (subSeqs.ContainsKey(temp))
                    {
                        subSeqs[temp] += 1;
                    }
                    else
                    {
                        subSeqs.Add(temp, 1);
                    }
                }
            }

            foreach (var (key, value) in subSeqs)
            {
                if (value > longestSeq)
                {
                    longestSeq = value;
                }
            }

            return longestSeq + 1;
        }
    }
}
