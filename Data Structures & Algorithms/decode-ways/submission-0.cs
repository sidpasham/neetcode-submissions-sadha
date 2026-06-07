public class Solution {
    public int NumDecodings(string s) {
        // edge case
        if (s == null || s.Length == 0 || s == "0" || s[0] == '0') {
            return 0;
        }

        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for(int i = 2; i <= s.Length; i++) {
            // one digit case
            int oneDigit = int.Parse(s.Substring(i-1, 1));
            if(oneDigit >= 1 && oneDigit <= 9) {
                dp[i] += dp[i-1];
            }

            // two digits case
            int twoDigit = int.Parse(s.Substring(i-2, 2));
            if(twoDigit >= 10 && twoDigit <= 26) {
                dp[i] += dp[i-2];
            }
        }

        return dp[n];
    }
}
