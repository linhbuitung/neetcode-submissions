public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var output = new int[n];

        // Prefix pass
        output[0] = 1;
        for (var i = 1; i < n; i++)
        {
            output[i] = output[i - 1] * nums[i - 1];
        }

        // Suffix pass
        var suffix = 1;
        for (var i = n - 1; i >= 0; i--)
        {
            output[i] *= suffix;
            suffix *= nums[i];
        }

        return output;
    }
}
