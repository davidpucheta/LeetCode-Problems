using LeetCode.Problems;
using LeetCode.ThirtyDaysOfCode;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var maxSubArray = new MaximunSubArray();
            var x = maxSubArray.MaxSubArray(new int[]{-2,-1});
            Console.WriteLine($" Answer: {x}");
        }
    }
}