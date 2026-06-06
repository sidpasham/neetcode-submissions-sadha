public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        // base case
        if (cost == null || cost.Length == 0) {
            return 0;
        }

        int n = cost.Length;

        int[] dp = new int[n];
        dp[0] = cost[0];
        dp[1] = cost[1];

        for(int i = 2; i< n; i++) {
            dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
        }

        return Math.Min(dp[n-1], dp[n-2]);
        
    }
}
