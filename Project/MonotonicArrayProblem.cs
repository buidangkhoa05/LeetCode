using System.IO.IsolatedStorage;

namespace _net_version.Project
{
    internal static class MonotonicArrayProblem
    {
        public static bool IsMonotonic(int[] nums)
        {
            int flag = 0; //  0 = undefine, 1 = increasing, 2 = decreasing

            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (flag == 0)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        continue;
                    }
                    else if (nums[i] > nums[i + 1])
                    {
                        flag = 2;
                        continue;
                    }
                    else
                    {
                        flag = 1;
                        continue;
                    }
                }
                else if (flag == 1)
                {
                    if (nums[i] > nums[i + 1])
                        return false;
                }
                else if (flag == 2)
                {
                    if (nums[i] < nums[i + 1])
                        return false;
                }
            }
            return true;

        }
    }
}
