using System.Text;

namespace LeetCode.Project;

public static class MergeAlternatelys
{
    public static string MergeAlternately(string word1, string word2)
    {
        if(word1.Length <= 0)
            return word2;

        if(word1.Length <= 0)
            return word1;
            
        int length = int.Max(word1.Length, word2.Length);
        StringBuilder newString = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            if (i < word1.Length)
            {
                newString = newString.Append(word1[i]);
            }

            if (i < word2.Length)
            {
                newString = newString.Append(word2[i]);
            }
        }

        return newString.ToString();
    }

}
