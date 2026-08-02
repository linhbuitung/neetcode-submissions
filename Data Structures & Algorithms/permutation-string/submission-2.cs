public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        var hash = new int[26];
        foreach (var c in s1)
        {
            hash[c - 'a']++;
        }

        var startingIndex = 0;
        for (var i = startingIndex; i < s1.Length; i++)
        {
            hash[s2[i] - 'a']--;
        }
        while (startingIndex < s2.Length - s1.Length)
        {
            if (hash.All(x => x == 0))
            {
                return true;
            }

            hash[s2[startingIndex] - 'a']++;
            startingIndex++;
            hash[s2[startingIndex + s1.Length - 1] - 'a']--;

        }
        return hash.All(x => x == 0);
    }
}
