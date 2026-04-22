public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // edge cases

        List<int> list = new List<int>();
        foreach (int num in nums) {
            if (num != val) {
                list.Add(num);
            }
        }

        for (int i = 0; i < list.Count; i++) {
            nums[i] = list[i];
        }

        return list.Count;    
    }
}