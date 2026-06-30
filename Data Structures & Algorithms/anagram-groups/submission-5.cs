public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // edgecases
        if(strs == null) {
            return null;
        }

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(var str in strs) {

            int[] count = new int[26];

            foreach(var ch in str) {
                count[ch - 'a']++;
            }

            string key = string.Join(",", count);

            if(!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.ToList();
    }
}
