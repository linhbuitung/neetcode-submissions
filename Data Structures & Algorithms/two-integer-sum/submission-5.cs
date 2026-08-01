public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.TryGetValue(complement, out int index)) {
                return new int[] { index, i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}
