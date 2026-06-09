public class Solution {
    public string MinWindow(string s, string t) {
        // Edge cases
        if (s == null || t == null || s.Length < t.Length || t.Length == 0) {
            return "";
        }

        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        // count the chars of c
        foreach(var c in t) {
            if(countT.ContainsKey(c)) {
                countT[c]++;
            } else {
                countT[c] = 1;
            }            
        }


        int have = 0;
        int need = countT.Count;      

        int l = 0;
        int r = 0;

        int shortest = int.MaxValue;
        int[] result = new int[2];

        while(r < s.Length) {
            var c = s[r];
            
            // count window chars
            if (window.ContainsKey(c)) {
                window[c]++;
            } else {
                window[c] = 1;
            }

            if(countT.ContainsKey(c) && window.ContainsKey(c)
             && countT[c] == window[c]) {                
                have++;
            }

            while(have == need) {
                var curLen = r - l + 1;
                if(curLen < shortest) {
                    result[0] = l;
                    result[1] = r;
                    shortest = curLen;
                }

                var leftChar = s[l];
                window[leftChar]--;

                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }

                l++;                
            }

            r++;            
        }

        return shortest == int.MaxValue ? "" : s.Substring(result[0], shortest);
    }
}
