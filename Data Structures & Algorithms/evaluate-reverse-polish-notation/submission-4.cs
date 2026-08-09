public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> calStack = new();
        foreach (var i in tokens)
        {
            switch (i)
            {
                case "+":
                {
                    var right = calStack.Pop();
                    calStack.Push(calStack.Pop() + right);
                    break;
                }
                case "-":
                {
                    var right = calStack.Pop();
                    calStack.Push(calStack.Pop() - right);
                    break;
                }
                case "*":
                {
                    var right = calStack.Pop();
                    calStack.Push(calStack.Pop() * right);
                    break;
                }
                case "/":
                {
                    var right = calStack.Pop();
                    calStack.Push(calStack.Pop() / right);
                    break;
                }
                default:
                {
                    calStack.Push(int.Parse(i));
                    break;
                }
            }
        }

        return calStack.Pop();
    }
}
