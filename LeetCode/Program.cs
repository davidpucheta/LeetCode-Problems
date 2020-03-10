using LeetCode.Problems;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
        
            var splitArr = new SplitArrayLargestSum();
            var nums = new int [] {2,3,1,2,4,3};

            var x = splitArr.SplitArray(nums, 5);
 
            Console.WriteLine($"m: {x}");
        }
    }
}