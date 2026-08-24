public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s == null && t == null) {
            return true;
        }

        // edge cases
        if (s.Length != t.Length) {
            return false;
        }

        int[] s_count = new int[256];
        int[] t_count = new int[256];

        foreach(var c in s) {
            s_count[c]++;
        }

        foreach(var c in t) {
            t_count[c]++;
        }

        foreach(var c in s) {
            if(t_count[c] != s_count[c]) {
                return false;
            }
        }

        return true;
    }
}
