public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        var subset = new List<int>();
        dfs(nums, subset, 0, res);
        return res;
    }

    public void dfs(int[] nums, List<int> subset, int i, List<List<int>> res) {
        if (i >= nums.Length) {
            res.Add(new List<int>(subset));
            return;
        }

        // left decision tree
        subset.Add(nums[i]);
        dfs(nums, subset, i+1, res);

        // right decision tree
        subset.Remove(nums[i]);
        while(i + 1 < nums.Length && nums[i] == nums[i+1]) {
            i++;
        }
        dfs(nums, subset, i+1, res);
    }
}
