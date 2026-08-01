public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new();
        foreach(char i in s)
        {
            if(!dict.ContainsKey(i))
            {
                dict.Add(i, 1);
            }
            else
            {
                dict[i]++;
            }
        }
        foreach(char i in t)
        {
            if(!dict.ContainsKey(i))
            {
                return false;
            }
            else
            {
                dict[i]--;
            }
        }
         foreach(var key in dict.Keys)
        {
            if(dict[key] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
