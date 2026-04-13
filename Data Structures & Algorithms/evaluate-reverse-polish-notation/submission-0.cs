public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        int result = 0;
        bool noOP = true;
        foreach(var t in tokens) {
            if(int.TryParse(t, out int val)) {
                stack.Push(val);
                continue;
            }

            if(stack.Count() == 0) {
                return result;
            }

            int second = stack.Pop();
            int first = stack.Pop();

            if(t == "/") {
                result = (first / second);
            }
            if(t == "+") {
                result = (first + second);
            }
            if(t == "-") {
                result = (first - second);
            }
            if(t == "*") {
                result = (first * second);
            }
            noOP = false;
            stack.Push(result);
        }

        if(noOP && stack.Count > 0) {
            result += stack.Pop();
        }

        return result;
    }
}
