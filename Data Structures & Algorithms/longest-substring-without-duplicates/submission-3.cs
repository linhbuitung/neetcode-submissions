public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var max = 0;
        var startingIndex = 0;
        var rightMostIndex = 0;
        HashSet<char> usedList = [];
     
        while (rightMostIndex < s.Length)
        {
            usedList.Add(s[startingIndex]);
            if (startingIndex != rightMostIndex && !usedList.Add(s[rightMostIndex]))
            {
                max = Math.Max(max, rightMostIndex - startingIndex);
                usedList.Remove(s[startingIndex]);
                startingIndex++;
            }
            else
            {
                rightMostIndex++;
            }
            
        }
        max = Math.Max(max, rightMostIndex - startingIndex);

        return max;
    }
}
