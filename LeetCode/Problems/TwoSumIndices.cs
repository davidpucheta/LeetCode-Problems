using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class TwoSumIndices
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }
    }
}
