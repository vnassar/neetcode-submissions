public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }

            if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if (stack.Count == 0) return false;

                var top = stack.Peek();
                char x = s[i];
                switch (x)
                {
                    case ')':
                        if (top == '(')
                        {
                            stack.Pop();
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    case '}':
                        if (top == '{')
                        {
                            stack.Pop();
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    case ']':
                        if (top == '[')
                        {
                            stack.Pop();
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                    return false;
                }
            }
        }
        bool any = (stack.Count == 0) ? true : false;
        return any;
    }
}
