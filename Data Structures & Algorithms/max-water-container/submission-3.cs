public class Solution {
    public int MaxArea(int[] heights) {

        int l = 0; 
        int r = heights.Length - 1;
        int max = 0;

        while (l < r) {
            int y = Math.Min(heights[l], heights[r]);
            int x = r - l;

            int cur = x * y;
            if (cur > max) {
                max = cur;
            }

            if (heights[l] <= heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return max;        
    }
}
