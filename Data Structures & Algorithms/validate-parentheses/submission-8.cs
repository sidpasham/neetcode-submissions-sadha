public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for(int i =0; i< s.Length; i++) {
            if(s[i] == '(') {
                stack.Push(')');
                continue;
            }
            if(s[i] == '[') {
                stack.Push(']');
                continue;
            }
            if(s[i] == '{') {
                stack.Push('}');
                continue;
            }

            // last closing should the element found, otherwise its not valid
            if(stack.Count == 0 || stack.Pop() != s[i]) {
                return false;
            }
        }

        // if still unprocessed brackets, then not valid
        if(stack.Count() > 0) {
            return false;
        }

        return true;
    }
}
