namespace LeetCode.Project
{
    internal static class NumberOfGoodPairsProblem
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int nbOfGoodPairs = 0;

            var dict = new Dictionary<int,int>();

            for(int i = 0; i < nums.Length; i++) 
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    nbOfGoodPairs += dict[nums[i]]++;
                }
            }

            return nbOfGoodPairs;
        }
    }
}
