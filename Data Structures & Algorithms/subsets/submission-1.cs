public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var res = new List<List<int>>();
        var subset = new List<int>();
        dfs(nums, subset, 0, res);
        return res;
    }

    public void dfs(int[] nums, List<int> subset, int i, List<List<int>> res) {
        if(i >= nums.Length) {
            var copy = new List<int>(subset);
            res.Add(copy);
            return;
        }

        // left decision tree
        subset.Add(nums[i]);
        dfs(nums, subset, i+1, res);

        // remove the elements while tracking back as slowly move up on right decision tree
        subset.Remove(subset[subset.Count - 1]);
        dfs(nums, subset, i+1, res);
    }
}
