public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stackTemp = new Stack<(int value, int index)>();
        var result = new int[temperatures.Length];
        for (var i = 0; i < temperatures.Length; i ++)
        {
            while (stackTemp.Count != 0 && stackTemp.Peek().value < temperatures[i])
            {
                var popped = stackTemp.Pop();
                result[popped.index] = i - popped.index;
            }
            
            stackTemp.Push((temperatures[i], i));
        }

        return result;
    }
}
