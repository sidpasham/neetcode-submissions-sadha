public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // edge case
        if(temperatures == null || temperatures.Length == 0) {
            return null;
        }

        Stack<(int temp, int index)> s = new Stack<(int temp, int index)>();
        int[] result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++) {
            // if my current temperature is warmer that previous day
            while (s.Count() > 0 && temperatures[i] > s.Peek().temp) {
                // pop the previous day
                var prev = s.Pop();

                // calculate the distance travelled and update result array
                result[prev.index] = i - prev.index;
            }

            // if no warmer day found, keep on adding to stack
            s.Push((temperatures[i], i));
        }

        return result;
    }
}
