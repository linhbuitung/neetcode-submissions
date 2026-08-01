public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var max = 0;
        while (left < right)
        {
            var containerHeight = Math.Min(heights[left], heights[right]);
            max = Math.Max(max, containerHeight * (right - left));
            if(heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return max;
    }
}
