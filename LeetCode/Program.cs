using LeetCode.Problems;
using LeetCode.ThirtyDaysOfCode;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var S = "ab#c";
            var T = "ad#c";
            
            var bckStrComparer = new BackspaceStringComparer();
            var x = bckStrComparer.BackspaceCompare(S, T);

            Console.WriteLine($" Answer: {x}");
        }
    }
}