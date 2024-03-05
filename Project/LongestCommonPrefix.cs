using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _net_version.Project
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefix1(string[] strs)
        {
            if (strs.Length == 1)
                return strs[0];

            strs = strs.OrderByDescending(x => x.Length).ToArray();

            var result = strs[strs.Length - 1];

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length != strs[0].Length)
                    break;

                while (strs[i].IndexOf(result) != 0)
                {
                    result = result[..^1];
                }

                if (string.IsNullOrEmpty(result))
                    return result;
            }

            return result;

        }
    }
}
