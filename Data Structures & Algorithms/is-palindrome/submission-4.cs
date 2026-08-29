public class Solution {
    public bool IsPalindrome(string s) {
        if(s == null) {
            return false;
        }

        int l = 0;
        int r = s.Length - 1;

        while(l < r) {
            if(!char.IsLetterOrDigit(s[l])) {
                l++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[r])) {
                r--;
                continue;
            }

            if(char.ToLowerInvariant(s[l]) != char.ToLowerInvariant(s[r])) {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }
}
