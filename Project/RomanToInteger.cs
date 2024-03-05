using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _net_version.Project
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = dict[s[s.Length - 1]];
            int tmpValue;

            for (int i = s.Length - 2; i >= 0; i--)
            {
                tmpValue = dict[s[i]];
                if (dict[s[i + 1]] > tmpValue)
                {
                    result -= tmpValue;
                }
                else
                {
                    result += tmpValue;
                }
            }

            return result;
        }
    }
}