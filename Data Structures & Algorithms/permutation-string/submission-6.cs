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
                char c = s2[j];

                // s2 count
                if (s2Count.ContainsKey(c)) {
                    s2Count[c]++;
                } else {
                    s2Count[c] = 1;
                }

                if (!s1Count.ContainsKey(c) || s1Count[c] < s2Count[c]) {
                    break;
                }

                if (s1Count[c] == s2Count[c]) {
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

    public void S2Count(string s2, Dictionary<char, int> s2Count) {
        foreach (char c in s2) {
            if (s2Count.ContainsKey(c)) {
                s2Count[c]++;
            } else {
                s2Count[c] = 1;
            }
        }
    }
}