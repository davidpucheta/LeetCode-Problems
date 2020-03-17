using LeetCode.Problems;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var longestAS = new LongestArithmeticSequence();
            var arr = new int[] { 83, 20, 17, 43, 52, 78, 68, 45};
            var x = longestAS.LongestArithSeqLength(arr);
 
            Console.WriteLine($" Answer: {x}");
        }
    }
}