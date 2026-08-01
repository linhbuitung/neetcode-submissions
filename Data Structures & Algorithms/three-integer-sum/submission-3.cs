public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = [];
        Array.Sort(nums);
        var firstIndex = 0;
        while(firstIndex < nums.Length - 2 && nums[firstIndex] <= 0)
        {
            var target = 0 - nums[firstIndex];
            var front = firstIndex + 1;
            var back = nums.Length - 1;

            while (front < back)
            {
                if (nums[front] + nums[back] == target && !result.Any(r => r.SequenceEqual([nums[firstIndex], nums[front], nums[back]])))
                {    
                    result.Add([nums[firstIndex], nums[front], nums[back]]);      
                }
                if (nums[front] + nums[back] < target)
                {
                    front++;
                }
                else
                {
                    back--;
                }
            }

            do
            {
                firstIndex++;
            }
            while (firstIndex < nums.Length && nums[firstIndex] == nums[firstIndex - 1]);
        }
        return result;
    }
}
