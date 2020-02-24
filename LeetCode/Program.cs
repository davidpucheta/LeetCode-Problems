using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var longestChar = new LongestRepeatedChar();
            Console.WriteLine( longestChar.MaxRepOpt1("baaabaaaaaaabaab"));
        }
    }
}