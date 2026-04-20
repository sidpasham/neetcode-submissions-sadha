public class Solution {
    public int MaxArea(int[] heights) {

        // edge cases

        int l = 0;
        int r = heights.Length - 1;
        int maxArea = 0;

        while (l < r) {
            int length = (r - l);
            int width = Math.Min(heights[l], heights[r]);
            int area = length * width;
            if(area > maxArea) {
                maxArea = area;
            }

            if(heights[l] <= heights[r]) {
                l++;
            } else {
                r--;
            }
        }

        return maxArea;        
    }
}
