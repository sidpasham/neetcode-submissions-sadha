public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        var results = new List<List<int>>();
        if(nums == null || nums.Length == 0) {
            return results;
        }
        
        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 1; i++) {
            // if it positive numbers we no longer need to check
            if (nums[i] > 0) {
                break;
            }

            // if same num as previous nums, then we skip it
            if(i > 0 && nums[i] == nums[i -1]) {
                continue;
            }

            int l = i + 1;
            int r = nums.Length -1;

            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r];

                if(sum < 0) {
                    l++;
                } else if (sum > 0) {
                    r--;
                } else {
                    results.Add(new List<int>() {nums[i], nums[l], nums[r]});
                    l++;
                    r--;

                    while (l < r && nums[l] == nums[l -1]) {
                        l++;
                    }
                }
            }
        }

        return results;
    }
}
