public class Solution {
    public int Rob(int[] nums) {
        // edge case
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        int n = nums.Length;
        if(n == 1) return nums[0];
        if(n == 2) return Math.Max(nums[0], nums[1]);

        int firstLinear = RobLinear(nums, 0, n - 2);
        int secondLinear = RobLinear(nums, 1, n - 1);

        return Math.Max(firstLinear, secondLinear);
    }

    public int RobLinear(int[] nums, int l, int r) {
        int n = r - l + 1;

        if(n == 1) return nums[l];
        if(n == 2) return Math.Max(nums[l], nums[l+1]);

        int[] dp = new int[n];
        dp[0] = nums[l];
        dp[1] = Math.Max(nums[l], nums[l+1]);

        for(int i = 2; i < n;i++) {
            dp[i] = Math.Max(dp[i-1], nums[l + i] + dp[i-2]);            
        }

        return dp[n-1];
    }
}
