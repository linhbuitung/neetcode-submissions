public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charactersOne = s.ToArray();
        char[] charactersTwo = t.ToArray();
        Array.Sort(charactersOne);
        Array.Sort(charactersTwo);
        return charactersOne.SequenceEqual(charactersTwo);
    }
}
