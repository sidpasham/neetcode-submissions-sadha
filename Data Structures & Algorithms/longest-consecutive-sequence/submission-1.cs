public class Solution {
    public int LongestConsecutive(int[] nums) {
        // edge cases

        var hs = new HashSet<int>(nums);

        int max = 0;

        foreach(var num in nums) {
            if(!hs.Contains(num - 1)) {
                int c = 0;
                int j = 0;
                while(hs.Contains(num + j)) {
                    c++;
                    j++;
                }

                if(c > max) {
                    max = c;
                }
            }
        }

        return max;        
    }
}
