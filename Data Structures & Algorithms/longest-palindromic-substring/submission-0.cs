public class Solution {
    public string LongestPalindrome(string s) {
        // edge case
        if(s == null || s.Length == 0) {
            return s;
        }

        int resIndex = 0;
        int resLength = 0;

        for(int i = 0; i < s.Length; i++) {
            // odd length
            int l = i;
            int r = i;
            while(l >=0 && r < s.Length && s[l] == s[r]) {
                if(r - l + 1 > resLength) {
                    resIndex = l;
                    resLength = r - l + 1;
                }
                l--;
                r++;
            }

            // even Length
            l = i;
            r = i+1;

            while(l >=0 && r < s.Length && s[l] == s[r]) {
                if(r - l + 1 > resLength) {
                    resIndex = l;
                    resLength = r - l + 1;
                }                
                l--;
                r++;
            }
        }

        return s.Substring(resIndex, resLength);
    }
}
