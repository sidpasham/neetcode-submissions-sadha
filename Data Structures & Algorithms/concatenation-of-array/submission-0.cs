public class Solution {
    public int[] GetConcatenation(int[] nums) {
        // edgecase
        int n = nums.Length;
        int[] ans = new int[2*n];
        int j = 0;
        for(int i =0; i<n;i++) {
            ans[j] = nums[i];
            j++;
        }
        for(int i =0; i<n;i++) {
            ans[j] = nums[i];
            j++;
        }

        return ans;
    }
}