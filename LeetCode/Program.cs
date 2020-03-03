using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var dnaSequences = new RepeatedDNASequences();
            var a = dnaSequences.FindRepeatedDnaSequences(s: "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}