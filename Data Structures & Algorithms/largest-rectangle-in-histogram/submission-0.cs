public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            int currentHeight;
            if (i == heights.Length)
            {
                currentHeight = 0;
            }
            else 
            {
                currentHeight = heights[i];
            }

            while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];
                int rightBoundary = i;
                int leftBoundary = stack.Count == 0 ? 0 : stack.Peek() + 1;

                int width = rightBoundary - leftBoundary;
                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}
