using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public static class MajorityElementProblem
    {
        public static int MajorityElement(int[] nums)
        {
            // normal 
            var countList = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if(countList.ContainsKey(num))
                    countList[num]++;
                else
                    countList[num] = 1;

                if(countList[num] > nums.Length / 2)
                    return num;                
            }

            return 0;

            //Boyer-Moore Voting Algorithm
            // var candidate = nums[0];
            // var count = 1;

            // for(int i = 1; i < nums.Length; i++)
            // {
            //     if(candidate == nums[i])
            //     {
            //         count++;
            //     }
            //     else 
            //     {
            //         count--;
            //         if(count == 0)
            //         {
            //             candidate = nums[i];
            //             count = 1;
            //         }
            //     }
            // }

            // return candidate;
        }
    }
}