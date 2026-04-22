public class Solution {
    public int MajorityElement(int[] nums) {
        // edgecase

        var map = new Dictionary<int, int>();
        int max = 0;
        int result = nums[0];

        foreach(var num in nums) {
            if(map.ContainsKey(num)) {
                map[num]++;
                int curMax = map[num];
                if(curMax > max) {
                    max = curMax;
                    result = num;
                }
            } else {
                map.Add(num, 1);
            }
        }

        return result;
    }
}