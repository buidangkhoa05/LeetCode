using System.Globalization;

namespace _net_version;

public static class ReverseVowelsOfaString
{
    public static string ReverseVowels(string s)
    {
        char[] charArr = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            var isLeftCharVowel = IsVowels(charArr[left]);
            var isRightCharVowel = IsVowels(charArr[right]);

            if (isLeftCharVowel && isRightCharVowel)
            {
                var tmp = charArr[left];
                charArr[left] = charArr[right];
                charArr[right] = tmp;

                left++;
                right--;
            }
            else
            {
                if (!isLeftCharVowel)
                    left++;

                if (!isRightCharVowel)
                    right--;
                
                continue;
            }
        }

        return string.Join("", charArr);
    }

    public static bool IsVowels(char c)
    {
        HashSet<char> vowels = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',
        };

        return vowels.TryGetValue(c, out _);
    }
}
