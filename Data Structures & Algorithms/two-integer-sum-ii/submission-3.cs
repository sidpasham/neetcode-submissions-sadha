public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers == null) {
            return new int[] {-1, -1};
        }

        int l = 0;
        int r = numbers.Length - 1;

        while (l < r) {
            int sum = numbers[l] + numbers[r];

            if(sum < target) {
                l++;
            } else if (sum > target) {
                r--;
            } else if (sum == target) {
                return new int[] {l + 1, r + 1};
            }
        }

        return new int[] {-1, -1};
    }
}
