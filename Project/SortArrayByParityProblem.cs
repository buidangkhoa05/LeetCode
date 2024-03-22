using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Project
{
    /// <summary>
    /// https://leetcode.com/problems/sort-array-by-parity/description/?envType=daily-question&envId=2024-01-21
    /// </summary>
    internal static class SortArrayByParityProblem
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] % 2 != 0)
                {
                    if (nums[right] % 2 == 0)
                    {
                        var tmp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = tmp;

                        left++;
                        right--;
                        continue;
                    }

                }
                else
                {
                    left++;
                }


                if (nums[right] % 2 != 0)
                {
                    right--;
                }
            }

            return nums;
        }
    }
}
