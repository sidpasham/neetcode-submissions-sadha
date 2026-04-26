public class Solution {
    public int Search(int[] nums, int target) {
        // TODO edgecases

        int l = 0;
        int r = nums.Length - 1; // 7

        while (l <=r) {
            int m = l + (r - l)/2; // 0 + 7/2 = 3

            // safe check
            if(target == nums[m]) {
                return m;
            }

            if(nums[l] <= nums[m]) {
                if(nums[l] <= target && target <= nums[m]) {
                    r = m -1;
                } else {
                    l = m + 1;
                }
            } else {
                if(nums[m] <= target && target <= nums[r]) {
                    l = m + 1;
                } else {
                    r = m - 1;
                }
            }
        }

        return -1;
    }

    // public int BinarySearch(int[] nums, int l1 , int r1, int target) {
    //     int l = l1; 
    //     int r = r1; 
    //     while (l <= r) {
    //         int m = l + (r -l)/2;

    //         if(nums[m] == target) {
    //             return m;
    //         } else if (target < nums[m]) {
    //             r = m -1;
    //         } else if (target > nums[m]) {
    //             l = m + 1;
    //         }
    //     }

    //     return -1;
    // }
}
