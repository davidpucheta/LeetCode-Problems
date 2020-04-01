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
            
            Array.Sort(A);

            var longestSeq = 0;
            var subSeqs = new Dictionary<int, int>();

            var maxInt = A[^1];
            
            
            
            
            return longestSeq + 1;
        }
    }
}
