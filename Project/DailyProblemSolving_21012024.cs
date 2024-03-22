using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace LeetCode.Project
{
    /// <summary>
    /// leetcode url : https://leetcode.com/problems/set-mismatch/?envType=daily-question&envId=2024-01-21
    /// tóm tắt: cho dãy hoán vị n. nhưng có 1 số bị trùng lặp (=> 1 số bị mất), tìm 2 số đó
    /// 
    /// solution: dùng dictionary đánh dấu lại:
    ///     key nào có value 2 => số trùng.
    ///     key nào ko có value => số mất.
    /// </summary>
    public class DailyProblemSolving_21012024
    {
        public int[] FindErrorNums(int[] nums)
        {
            var numDict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!numDict.ContainsKey(num))
                {
                    numDict.Add(num, 1);
                }
                else
                {
                    numDict[num]++;
                }
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!numDict.ContainsKey(i))
                {
                    numDict.Add(i, -1);
                }
            }

            return numDict.Where(x => x.Value == 2 || x.Value == -1).Select(x => x.Key).ToArray();
        }
    }
}