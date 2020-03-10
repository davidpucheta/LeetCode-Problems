using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    public class SplitArrayLargestSum
    {
        public int SplitArray(int[] nums, int m)
        {
            var numsLength = nums.Length;

            if (numsLength == 0)
            {
                return 0;
            }

            var memo = new int[numsLength + 1];
            memo[0] = 0;
            var maxInt = 0;
            for (int i = 0; i < numsLength; i++)
            {
                memo[i + 1] = memo[i] + nums[i];
                maxInt = nums[i] > maxInt ? nums[i] : maxInt;
            }

            if (m == numsLength)
            {
                return maxInt;
            }
            
            var outputArr = new int[numsLength];
            for (int i = 0; i < numsLength; i++)
            {
                outputArr[i] = memo[numsLength] - memo[i];
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < numsLength - i; j++)
                {
                    outputArr[j] = Int32.MaxValue;
                    for (int k = 0; k < numsLength - i; k++)
                    {
                        int temp = Math.Max(outputArr[k], memo[k] - memo[j]);
                        if (temp <= outputArr[j])
                        {
                            outputArr[j] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return outputArr[0];
        }
    }
}