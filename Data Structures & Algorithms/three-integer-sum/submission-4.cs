public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // edge cases

        var result = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0; i<nums.Length; i++) {
            // edge case
            if (nums[i] > 0) {
                break;
            }
            // edge case
            if(i > 0 && nums[i] == nums[i-1]) {
                continue;
            }
            int l = i + 1;
            int r = nums.Length -1;

            // two sum
            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r];
                if(sum < 0) {
                    l++;
                } else if (sum > 0) {
                    r--;
                } else {
                    result.Add(new List<int>() {nums[i], nums[l], nums[r]});
                    l++;
                    r--;

                    // edge case
                    while(l < r && nums[l] == nums[l -1]) {
                        l++;
                    }
                }
                
            }
        }

        return result;        
    }
}
