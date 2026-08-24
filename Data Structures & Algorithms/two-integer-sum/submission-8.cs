public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null) {
            return new int[2] {-1, -1};
        }

        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int y = target - nums[i];
            if(map.ContainsKey(y) && i != map[y]) {
                return new int[] {map[y], i};
            } else {
                map.Add(nums[i], i);
            }
        }

        return new int[2] {-1, -1};
    }
}
