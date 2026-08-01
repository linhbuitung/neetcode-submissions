public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        var longest = 0;
        foreach (var i in nums)
        {
            if (set.Contains(i-1)) continue;
            var len = 0;
            while (set.Contains(i + len))
            {
                len++;
            }
            longest = Math.Max(longest, len);
        }
        return longest;
    }
}
