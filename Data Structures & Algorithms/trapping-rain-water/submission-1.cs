public class Solution {
    public int Trap(int[] height) {
        var leftHighList = new int[height.Length];
        var rightHighList = new int[height.Length];

        for (var i = 1; i < height.Length; i++)
        {
            leftHighList[i] = Math.Max(leftHighList[i - 1], height[i - 1]);
        }
        for (var i = height.Length - 2; i >= 0; i--)
        {
            rightHighList[i] = Math.Max(rightHighList[i + 1], height[i + 1]);
        }

        return height.Select((t, i) => Math.Max(0, Math.Min(leftHighList[i], rightHighList[i]) - t)).Sum();
    }
}
