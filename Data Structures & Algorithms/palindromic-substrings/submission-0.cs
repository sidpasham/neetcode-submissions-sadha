public class Solution {
    public int CountSubstrings(string s) {
        // edge case
        if(s == null || s.Length == 0) {
            return 0;
        }

        int count = 0;

        for(int i = 0; i < s.Length; i++) {
            //odd Length
            int l = i;
            int r = i;
            while(l >=0 && r < s.Length && s[l] == s[r]) {
                count++;
                l--;
                r++;
            }

            //even Length
            l = i;
            r = i+1;
            while(l >=0 && r < s.Length && s[l] == s[r]) {
                count++;
                l--;
                r++;
            }
        }

        return count;
    }
}
