using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// leetcode url: https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TowSumChallenge
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];
                if (numDict.ContainsKey(dif))
                {
                    return [numDict[dif], i];
                }
                else
                {
                    numDict.Add(nums[i], i);
                }
            }
            
            return [];
        }
    }
}