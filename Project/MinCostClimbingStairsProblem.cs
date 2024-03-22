namespace LeetCode.Project
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-climbing-stairs/submissions/1184110079/?envType=daily-question&envId=2024-01-21
    /// </summary>
    internal static class MinCostClimbingStairsProblem
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            // Dynamic programming approach

            int firstState = cost[1]; // start at 1st index - the state closest to the current state 
            int secondState = cost[0]; // satrt at 0th index - the state furthest from the current state

            int currentVal = 0;

            for (int i = 2; i < cost.Length; i++)
            {
                // current val = cost at i index + min value of first and second state
                currentVal = cost[i] + Math.Min(firstState, secondState);

                //update the first and second state
                secondState = firstState;
                firstState = currentVal;
            }

            return Math.Min(secondState, firstState);
        }
    }
}
