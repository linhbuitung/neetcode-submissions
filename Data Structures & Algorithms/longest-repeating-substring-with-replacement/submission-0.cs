public class Solution {
    public int CharacterReplacement(string s, int k) {
        var frequency = new int[26];
        var left = 0;
        var max = 0;
        var result = 0;

        for (var right = 0; right < s.Length; right++) {
            var index = s[right] - 'A';
            frequency[index]++;

            max = Math.Max(max, frequency[index]);

            while (right - left + 1 - max > k) {
                frequency[s[left] - 'A']--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
