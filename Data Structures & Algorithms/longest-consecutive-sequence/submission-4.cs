public class Solution {
    public int LongestConsecutive(int[] nums) {
        int result = 0;

        // edgecase
        if(nums == null) {
            return result;
        }

        var hs = new HashSet<int>(nums);

        foreach(var num in hs) {
            if(!hs.Contains(num -1)) {
                int current = 1;
                int find = num;

                while(hs.Contains(find + 1)) {
                    find++;
                    current++;
                }

                result = Math.Max(current, result);
            }
        }

        return result;
    }
}
