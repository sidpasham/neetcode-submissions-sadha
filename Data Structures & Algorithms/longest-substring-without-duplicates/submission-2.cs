public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // edgecases
        // x y z z

        int l =0;
        int r = 0;
        int longest = 0;
        var hs = new HashSet<char>();

        while (r < s.Length) {
            // making sure in my window there is no duplicate elements
            while(hs.Contains(s[r])) {
                hs.Remove(s[l]);
                l++;
            }
            hs.Add(s[r]);
            int window = r - l + 1;
            longest = Math.Max(window, longest);
            r++;
        }

        return longest;
    }
}
