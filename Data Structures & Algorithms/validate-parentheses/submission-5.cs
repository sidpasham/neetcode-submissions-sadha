public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for(int i =0; i< s.Length; i++) {
            if(s[i] == '[' || s[i] == '(' || s[i] == '{') {
                stack.Push(s[i]);
            }
            else if (s[i] == ']') {
                if(stack.Count() == 0) {
                    return false;
                }

                if(stack.Peek() == '[') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (s[i] == ')') {
                if(stack.Count() == 0) {
                    return false;
                }
                if(stack.Peek() == '(') {
                    stack.Pop();
                } else {
                    return false;
                }
            } else if (s[i] == '}') {
                if(stack.Count() == 0) {
                    return false;
                }
                if(stack.Peek() == '{') {
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }

        if(stack.Count() > 0) {
            return false;
        }

        return true;
    }
}
