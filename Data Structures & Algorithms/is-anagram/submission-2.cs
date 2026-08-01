public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] hash = new int[26];
        foreach(char i in s)
        {
            hash[i-97]++;
        }
        foreach(char i in t)
        {
            hash[i-97]--;
        }
        foreach(var character in hash)
        {
            if(character != 0)
            {
                return false;
            }
        }
        return true;
    }
}
