public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // edge cases

        var map = new Dictionary<int, int>();

        for(int i =0; i<nums.Length; i++) {
            var find = target - nums[i];
            if(map.ContainsKey(find) && map[find] != i) {
                return new int[] {map[find], i};
            } else {
                map.Add(nums[i], i);
            }
        }

        return new int[] {-1, -1};
    }
}
