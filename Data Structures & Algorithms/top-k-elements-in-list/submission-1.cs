public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // 1. Count frequencies
        Dictionary<int, int> freq = new();
        foreach (int n in nums)
        {
            if (!freq.ContainsKey(n))
                freq[n] = 0;
            freq[n]++;
        }

        // 2. Bucket sort: index = frequency, value = list of numbers
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in freq)
        {
            int number = pair.Key;
            int count = pair.Value;

            if (buckets[count] == null)
            {
                buckets[count] = new List<int>();
            }

            buckets[count].Add(number);
        }

        // 3. Collect top k from highest frequency bucket
        List<int> result = new();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return result.Take(k).ToArray();
    }
}
