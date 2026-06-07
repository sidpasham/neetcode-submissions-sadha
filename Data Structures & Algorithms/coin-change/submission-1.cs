public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // Base case: If the target is 0, you need 0 coins
        if (amount == 0) return 0;
        if (coins == null || coins.Length == 0) return -1;

        // Size the array to hold every amount from 0 to target amount
        int[] dp = new int[amount + 1];

        // Fill the rest of the array with a high value placeholder (infinity-like)
        // We use amount + 1 because you can never need more coins than the amount itself
        Array.Fill(dp, amount+1);
        
        // Base case 0: Making 0 dollars takes 0 coins
        dp[0] = 0;

        // Loop through every single amount up to your target
        for (int i = 1; i <= amount; i++) {
            // Check every coin denomination we have available
            for (int c = 0; c < coins.Length; c++) {
                int coinValue = coins[c];

                // Can we actually use this coin? (Amount must be greater than or equal to the coin)
                if (i - coinValue >= 0) {
                    // Look backward to dp[i - coinValue] and pick the minimum path
                    dp[i] = Math.Min(dp[i], dp[i - coinValue] + 1);
                }
            }
        }

        // If the final slot was never updated, it means the amount is impossible to make
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
