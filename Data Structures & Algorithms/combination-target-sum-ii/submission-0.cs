public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);

        var res = new List<List<int>>();
        var subset = new List<int>();

        dfs(candidates, target, 0, 0, subset, res);
        return res;
    }

    public void dfs(int[] nums, int target, int sum, int i, List<int> subset, List<List<int>> res) {
        if(sum == target) {
            res.Add(new List<int>(subset));
            return;
        }

        if(i >= nums.Length || sum > target) {
            return;
        }

        subset.Add(nums[i]);
        dfs(nums, target, sum + nums[i], i+1, subset, res);

        subset.Remove(nums[i]);

        while(i+1 < nums.Length && nums[i] == nums[i+1]) {
            i++;
        }

        dfs(nums, target, sum, i+1, subset, res);
    }
}
