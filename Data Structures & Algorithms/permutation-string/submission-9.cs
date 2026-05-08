public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // calculate counts for s1
        Dictionary<char, int> s1Count = new Dictionary<char, int>();
        S1Count(s1, s1Count);
        int need = s1Count.Count;

        // loop through s2
        for (int i = 0; i < s2.Length; i++) {
            Dictionary<char, int> s2Count = new Dictionary<char, int>();
            int have = 0;
            for (int j = i; j < s2.Length; j++) {
                char s2Char = s2[j];

                // s2 count
                S2Count(s2Char, s2Count);

                if (!s1Count.ContainsKey(s2Char) || s1Count[s2Char] < s2Count[s2Char]) {
                    break;
                }

                if (s1Count[s2Char] == s2Count[s2Char]) {
                    have++;
                }

                if (have == need) {
                    return true;
                }
            }
        }
        return false;
    }

    public void S1Count(string s1, Dictionary<char, int> s1Count) {
        foreach (char c in s1) {
            if (s1Count.ContainsKey(c)) {
                s1Count[c]++;
            } else {
                s1Count[c] = 1;
            }
        }
    }

    public void S2Count(char c, Dictionary<char, int> s2Count) {
        if (s2Count.ContainsKey(c)) {
            s2Count[c]++;
        } else {
            s2Count[c] = 1;
        }
    }
}