public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new  int[nums.Length];
        
        result[0] = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            result[i] = result[i-1] * nums[i - 1];
        }
        var temp = 1;
        for (var i = nums.Length - 1 ; i > -1; i--)
        {
            result[i] *= temp;
            temp *= nums[i];
        }
        return result;
    }
}
