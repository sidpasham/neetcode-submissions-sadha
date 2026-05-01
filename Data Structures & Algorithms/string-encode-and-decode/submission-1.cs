public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int l = 0;
        int r = s.Length;
        int j = 0;

        List<string> result = new List<string>();
        // 5#Hello5#World
        //  j
        
        while(l < r) { //
            if(s[j] == '#') {
                // j=1, 0 -> 1
                // j =8, 7 -> 1
                int len = int.Parse(s.Substring(l, j-l));
                // 2, 2->5
                // 9, 9 -> 5
                result.Add(s.Substring(j+1, len));
                l = j+len+1; //1+5+1 = 7, 8+5+1=14
                j=l; // j=7, j=15
            }
            j++; //j = 1, j=8, j=16
        }

        return result;
   }
}
