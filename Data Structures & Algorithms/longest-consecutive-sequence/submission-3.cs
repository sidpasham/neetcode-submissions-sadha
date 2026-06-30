public class Solution {
    public int LongestConsecutive(int[] nums) {
        // edge cases

        // fill up the hashset
        var hs = new HashSet<int>(nums);

        int max = 0;

        foreach(var num in nums) {
            if(!hs.Contains(num - 1)) {
                int c = 1;
                int j = 1;
                while(hs.Contains(num + j)) {
                    c++;
                    j++;
                }

                max = Math.Max(c, max);
            }
        }

        return max;        
    }
}
