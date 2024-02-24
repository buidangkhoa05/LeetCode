using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _net_version.Project
{
    internal class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            if (n == 1 || n == 5)
                return false;

            var visited = new HashSet<int>();
            int rs = n;
            while (rs != 1)
            {
                if(!visited.Add(rs))
                    break;

                rs = Calculate(rs);
            }
            return rs == 1;
        }

        public static int Calculate(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                var current = n % 10;
                sum += current * current;
                n /= 10;
            }
            return sum;
        }
    }
}
