using LeetCode.Problems;
using LeetCode.ThirtyDaysOfCode;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var x = minStack.GetMin();  
            minStack.Pop();
            var y = minStack.Top();      
            var z = minStack.GetMin();   
            
             

            Console.WriteLine($" Answer: {x}, {y}, {z}");
        }
    }
}