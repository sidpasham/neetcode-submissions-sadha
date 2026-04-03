public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //edgecases

        var map = new Dictionary<int, int>();

        for(int i =0; i< numbers.Length;i++) {
            map.Add(numbers[i], i);
        }

        for(int i =0; i<numbers.Length;i++) {
            int y = target - numbers[i];

            if(map.ContainsKey(y)) {
                return new int[] {i + 1, map[y] + 1};
            }
        }

        return new int[] {0, 0};        
    }
}
