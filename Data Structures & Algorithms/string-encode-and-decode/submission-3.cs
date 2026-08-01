public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach (string s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            // find the '#'
            while (s[j] != '#')
                j++;

            int length = int.Parse(s.Substring(i, j - i));
            j++; // move past '#'

            string word = s.Substring(j, length);
            result.Add(word);

            i = j + length;
        }

        return result;
    }
}
