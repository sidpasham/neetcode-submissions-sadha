public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var res = new List<List<int>>();
        var subset = new List<int>();
        var used = new bool[nums.Length];
        dfs(nums, subset, 0, res, used);
        return res;
    }

    public void dfs(int[] nums, List<int> subset, int i, List<List<int>> res, bool[] used) {
        if(i >= nums.Length) {
            res.Add(new List<int>(subset));
            return;
        }

        // for all possible elements try backtracking
        for(int j = 0; j < nums.Length; j++) {
            // if its already there, don't add it again
            if(used[j]) continue;

            // mark as present and add it to subset
            used[j] = true;
            subset.Add(nums[j]);

            dfs(nums, subset, i+1, res, used);

            // remove and backtracking, while backtracking mark it as not present
            subset.RemoveAt(subset.Count - 1);
            used[j] = false;
        }

    }
}
