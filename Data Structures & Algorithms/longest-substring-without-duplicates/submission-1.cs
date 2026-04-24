public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // edgecases
        // x y z z

        int l =0;
        int r = 0;
        int longest = 0;
        var hs = new HashSet<char>();

        while (r < s.Length) {
            while(hs.Contains(s[r])) {
                hs.Remove(s[l]);
                l++;
            }
            hs.Add(s[r]);
            int cur = r - l + 1;
            if (cur > longest) {
                longest = cur;
            }
            r++;
        }

        return longest;
    }
}
