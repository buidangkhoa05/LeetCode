namespace _net_version;

public class DailyProblemSolving_26012024
{
    public static int PivotIndex(int[] nums)
    {
        var sumArr = new int[nums.Length];
        sumArr[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            sumArr[i] = nums[i] + sumArr[i - 1];
        }
        for (int i = 0; i < sumArr.Length; i++)
        {
            int leftValue = i - 1 < 0 ? 0 : sumArr[i - 1]; 
            int rightValue = sumArr[sumArr.Length - 1] - sumArr[i];
            if (leftValue == rightValue)
                return i;
        }
        return -1;
    }

}
