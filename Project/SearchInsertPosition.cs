namespace _net_version.Project
{
    internal static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                var mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }

            }

            if (nums[start] < target)
            {
                return start + 1;
            }
            else if (nums[start] > target)
            {
                return start;
            }
            else
            {
                return start;
            }
        }
    }
}
