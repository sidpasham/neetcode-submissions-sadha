public class Solution {

    public string Encode(IList<string> strs) {
        // edgecases
        if (strs == null) {
            return null;
        }

        StringBuilder sb = new StringBuilder();

        foreach(var str in strs) {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        // edge cases
        if (s == null) {
            return null;
        }

        int l = 0;
        int r = s.Length;
        int j = 0;

        List<string> results = new List<string>();

        while (l < r) {

            if (s[j] == '#') {

                int len = int.Parse(s.Substring(l, j-l));

                results.Add(s.Substring(j + 1, len));

                l = j+len+1;
                j = l;
            }

            j++;
        }

        return results;
   }
}
