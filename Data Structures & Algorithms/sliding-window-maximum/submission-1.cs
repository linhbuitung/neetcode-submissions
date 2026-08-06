public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0 || k <= 0)
            return Array.Empty<int>();

        if (k == 1)
            return nums;

        var n = nums.Length;
        var result = new int[n - k + 1];
        LinkedList<int> deque = new(); 

        for (var i = 0; i < n; i++)
        {
            while (deque.Count > 0 && deque.First!.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last!.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.First!.Value];
            }
        }

        return result;
    }
}
