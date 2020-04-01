using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class SingleNumber
    {
        public int SingleNumberInArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            var numsCount = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numsCount.ContainsKey(num))
                {
                    numsCount[num] += numsCount[num] + 1;
                }
                else
                {
                    numsCount.Add(num, 1);
                }
            }

            foreach (var item in numsCount)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return 0;
        }
    }
}