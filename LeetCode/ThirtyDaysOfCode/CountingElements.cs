using System;

namespace LeetCode.ThirtyDaysOfCode
{
    public class CountingElements
    {
        public int CountElements(int[] arr)
        {
            var output = 0;

            foreach (var num in arr)
            {
                if (Array.IndexOf(arr, num + 1) != -1)
                { 
                    output += 1; 
                }
            }
            
            return output;
        }
    }
}