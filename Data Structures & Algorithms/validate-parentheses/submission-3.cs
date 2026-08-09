public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        foreach (var t in s)
        {
            switch (t)
            {
                case ')':
                {
                    if (stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    break;
                }
                case '}':
                {
                    if (stack.Count != 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    break;
                }
                case ']':
                {
                    if (stack.Count != 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    break;
                }
                default:
                {
                    stack.Push(t);
                    break;
                }
            }
        }

        return stack.Count == 0;
    }
}
