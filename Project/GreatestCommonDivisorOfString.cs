using System.ComponentModel;

namespace LeetCode.Project;

public static class GreatestCommonDivisorOfStrings
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if(str1 + str2 != str2 + str1)
            return "";

        int gcd = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcd);
    }

    public static int GCD(int a, int b)
    {
        if(a == 0 || b == 0)
        return a + b;

        while(a * b != 0)
        {
            if(a > b )
            {
                a %= b;
            }
            else 
            {
                b %= a;
            }
        }

        return a + b;
    }
}
