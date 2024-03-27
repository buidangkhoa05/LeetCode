namespace _net_version;

public class MovesZero
{
    public static void MoveZeroes(int[] nums)
    {
        if (nums.Length <= 1)
            return;

        int index1 = 0;
        int index2 = 1;

        while (index1 < nums.Length && index2 < nums.Length)
        {
            if (nums[index1] == 0 && nums[index2] != 0)
            {
                nums[index1] = nums[index2];
                nums[index2] = 0;

                index1++;
                index2++;
            }
            else if (nums[index1] == 0 && nums[index2] == 0)
            {
                index2++;
            }
            else if (nums[index1] != 0 && nums[index2] == 0)
            {
                index1 = index2;
                index2++;
            }
            else
            {
                index1++;
                index2++;
            }
        }
    }
}
