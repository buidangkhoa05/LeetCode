using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Project
{
    public static class ValidParentheses
    {
        public static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new();

            foreach (var str in s)
            {
                if (str == '(' || str == '{' || str == '[')
                {
                    stack.Push(str);
                }
                else
                {
                    if (str == '(' || str == '{' || str == '[')
                    {
                        stack.Push(str);
                    }
                    else
                    {
                        if (stack.Count() == 0)
                            return false;

                        if ((str == ')' && stack.Peek() == '(')
                            || (str == '}' && stack.Peek() == '{')
                            || (str == ']' && stack.Peek() == '['))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count() > 0)
                return false;
            return true;
        }
    }


}
