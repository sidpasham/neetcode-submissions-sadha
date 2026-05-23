public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var res = new List<string>();
        var subset = new List<char>();
        dfs(n, subset, 0, res, 0, 0);
        return res;
    }

    public void dfs(int n, List<char> subset, int i, List<string> res, int open, int close) {
        if(i >= 2*n) {
            res.Add(new string(subset.ToArray()));
            return;
        }

        if (open < n) {
            subset.Add('(');

            dfs(n, subset, i + 1, res, open+1, close);

            subset.RemoveAt(subset.Count - 1);
        }

        if(close < open) {
            subset.Add(')');

            dfs(n, subset, i + 1, res, open, close + 1);

            subset.RemoveAt(subset.Count - 1);
        }
    }
}
