public class Solution {
    public int MaxProfit(int[] prices) {
        // edgecases
        int l = 0;
        int r = 1;
        int result = 0;

        while(r < prices.Length) {
            if(prices[l] >= prices[r]) {
                l = r;
            } else {
                int cur = prices[r] - prices[l];
                result = Math.Max(cur, result);
            }
            r++;
        }

        return result;
    }
}
