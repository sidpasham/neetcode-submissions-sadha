public class Solution {
    public int CharacterReplacement(string s, int k) {
        // edge cases
        int l = 0;
        int r = 0;
        var count = new Dictionary<char, int>();
        int maxf = 0;
        int longest = 0;
        while(r < s.Length) {
            // get counts
            if(count.ContainsKey(s[r])) {
                count[s[r]]++;
            } else {
                count.Add(s[r], 1);
            }
            maxf = Math.Max(maxf, count[s[r]]);

            // sliding window condition
            int windowLength = r - l + 1;
            if(windowLength - maxf > k) {
                count[s[l]]--;
                l++;                
            }
            
            // calculate max length
            int cur = r - l + 1;
            longest = Math.Max(cur, longest);
            r++;
        }
        return longest;
    }
}
