public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var res = new List<List<int>>();
        var subset = new List<int>();
        dfs(nums, target, 0, 0, subset, res);
        return res;
    }

    public void dfs(int[] nums, int target, int i, int sum, List<int> subset, List<List<int>> res) {
        if(sum == target) {
            res.Add(new List<int>(subset));
            return;
        }

        if(i >= nums.Length || sum > target) {
            return;
        }

        // left decision tree
        subset.Add(nums[i]);
        dfs(nums, target, i, sum + nums[i], subset, res);

        // move up slowly by removing the element on right decision tree
        subset.Remove(nums[i]);
        dfs(nums, target, i+1, sum, subset, res);
    }
}
