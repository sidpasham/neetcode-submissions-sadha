public class Solution {
    public int SubarraySum(int[] nums, int k) {

        int preSum = 0;
        var dict = new Dictionary<int, int>();
        int result = 0;

        dict[0] = 1;

        foreach(var num in nums) {
            preSum = preSum + num;
            int diff = preSum - k;

            if(dict.ContainsKey(diff)) {
                result = result + dict[diff];
            }

            if(!dict.ContainsKey(preSum)) {
                dict[preSum] = 0;
            }

            dict[preSum]++;
        }

        return result;
    }
}