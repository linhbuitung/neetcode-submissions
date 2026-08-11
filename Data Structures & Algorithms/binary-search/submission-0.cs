public class Solution {
    public int Search(int[] nums, int target) {
        Array.Sort(nums);
        var right = nums.Length - 1;
        var left = 0;
        int mid;
        while (left <= right)
        {
            mid = (right + left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            } 
            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
