using LeetCode.Problems;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var longestAS = new LongestArithmeticSequence();
            var arr = new int[] {20,1,15,3,10,5,8,9,4,7,2};
            var x = longestAS.LongestArithSeqLength(arr);
 
            Console.WriteLine($" Answer: {x}");
        }
    }
}