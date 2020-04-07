using LeetCode.Problems;
using LeetCode.ThirtyDaysOfCode;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var elCount = new CountingElements();
            var x = elCount.CountElements(new int[]{1,2,3});
            Console.WriteLine($" Answer: {x}");
        }
    }
}