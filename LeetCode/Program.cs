using LeetCode.Problems;
using LeetCode.ThirtyDaysOfCode;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var happy = new HappyNumber();
            var x = happy.IsHappy(2);
            Console.WriteLine($" Answer: {x}");
        }
    }
}