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

        for(int j = 0; j < nums.Length; j++) {
            if(used[j]) continue;

            used[j] = true;
            subset.Add(nums[j]);

            dfs(nums, subset, i+1, res, used);

            subset.RemoveAt(subset.Count - 1);
            used[j] = false;
        }

    }
}
