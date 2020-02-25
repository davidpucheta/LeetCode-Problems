using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var minParenthesis = new MinAddParenthesis();

           var a = minParenthesis.MinAddToMakeValid("())");
            var b = minParenthesis.MinAddToMakeValid("(((");
            var c = minParenthesis.MinAddToMakeValid("()");
            var d = minParenthesis.MinAddToMakeValid("()))((");

            Console.WriteLine($"{a} {b} {c} {d}");
        }
    }
}