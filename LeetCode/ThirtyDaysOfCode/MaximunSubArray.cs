using System;
using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class MaximunSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            var result = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                result = nums[i] > result ? nums[i] : result;

                var temp = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp += nums[j];
                    result = temp > result ? temp : result;
                }
            }
            return result;
        }
    }
}