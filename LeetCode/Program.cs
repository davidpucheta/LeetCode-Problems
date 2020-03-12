using LeetCode.Problems;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var removeDigits = new RemoveKDigits();
            var x = removeDigits.RemoveKdigits("123456789", 8);
 
            Console.WriteLine($"x: {x}");
        }
    }
}