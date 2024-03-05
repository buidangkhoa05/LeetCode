using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _net_version.Project
{
    /// <summary>
    /// url : https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            int reverseNumber = 0;
            int firstValue = x;

            if (firstValue < 0)
                return false;

            if (firstValue < 10)
                return true;

            while (firstValue > 0)
            {
                reverseNumber = reverseNumber * 10 + firstValue % 10;
                firstValue /= 10;
            }

            if (x != reverseNumber)
                return false;
            return true;
        }
    }
}