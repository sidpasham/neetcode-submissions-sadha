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

        // left decision tree
        subset.Add(nums[i]);
        dfs(nums, target, sum + nums[i], i+1, subset, res);

        // move up slowly by removing the last element
        subset.Remove(nums[i]);
        // remove duplicates
        while(i+1 < nums.Length && nums[i] == nums[i+1]) {
            i++;
        }

        dfs(nums, target, sum, i+1, subset, res);
    }
}
