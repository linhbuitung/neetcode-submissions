public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length)
        {
            return "";
        }

        var need = new Dictionary<char, int>();
        foreach (var c in t) {
            if (!need.ContainsKey(c))
            {
                need[c] = 0;
            }
            need[c]++;
        }

        var required = need.Count;
        var formed = 0;

        var window = new Dictionary<char, int>();
        int left = 0, right = 0;

        var minLen = int.MaxValue;
        var minLeft = 0;

        while (right < s.Length) {
            var c = s[right];
            if (!window.ContainsKey(c))
            {
                window[c] = 0;
            }
            window[c]++;

            if (need.ContainsKey(c) && window[c] == need[c]) {
                formed++;
            }

            while (left <= right && formed == required) {
                if (right - left + 1 < minLen) {
                    minLen = right - left + 1;
                    minLeft = left;
                }

                var leftChar = s[left];
                window[leftChar]--;

                if (need.ContainsKey(leftChar) && window[leftChar] < need[leftChar]) {
                    formed--;
                }

                left++;
            }

            right++;
        }

        return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);
    }
}
