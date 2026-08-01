public class Solution {
    public bool IsPalindrome(string s) {
        var front = 0;
        var back = s.Length - 1;
        while (front < s.Length && !char.IsLetterOrDigit(s[front]))
        {
            front++;
        }
        while (back > -1 && !char.IsLetterOrDigit(s[back]))
        {
            back--;
        }
        while (front < back)
        {
            if (char.ToLower(s[front]) != char.ToLower(s[back]))
            {
                return false;
            }

            do
            {
                front++;
            } while (front < s.Length && !char.IsLetterOrDigit(s[front]));
            do
            {
                back--;
            } while (back > -1 && !char.IsLetterOrDigit(s[back]));
        }
        return true;
    }
}
