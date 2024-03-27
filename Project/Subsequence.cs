namespace _net_version;

public static class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        int tmp = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var current = t.IndexOf(s[i], tmp);
            if (current == -1)
                return false;
            else
            {
                tmp = current + 1;
            }
        }
        return true;
    }
}
