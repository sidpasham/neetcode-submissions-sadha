public class Solution {
    public int SubarraySum(int[] nums, int k) {

        //edge cases

        int preSum = 0;
        var dict = new Dictionary<int, int>();
        int result = 0;

        // include the curr element value
        dict[0] = 1;

        foreach(var num in nums) {
            // calculate PrefixSum
            preSum = preSum + num;

            //check if my delta
            int diff = preSum - k;

            // if delta exists in map, I already have the count of array
            if(dict.ContainsKey(diff)) {
                result = result + dict[diff];
            }

            // add the edge case where if the preSum does not exists then
            // assign it with 0
            if(!dict.ContainsKey(preSum)) {
                dict[preSum] = 0;
            }

            // increment the count for preSum element
            dict[preSum]++;
        }

        return result;
    }
}