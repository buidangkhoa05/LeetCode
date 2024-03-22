using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Project
{
    internal static class BackspaceStringCompare
    {

        public static bool BackspaceCompare(string s, string t)
        {
            var sStack = new Stack<char>();
            var tStack = new Stack<char>();

            foreach (var c in s)
            {
                PushToStack(c, ref sStack);
            }

            foreach (var c in t)
            {
                PushToStack(c, ref tStack);
            }

            if (sStack.Count != tStack.Count)
                return false;

            while (sStack.Count > 0)
            {
                if (sStack.Pop() != tStack.Pop())
                    return false;
            }
            return true;
        }

        public static void PushToStack(char c, ref Stack<char> stack)
        {

            if (c == '#')
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }
        //public static bool BackspaceCompare(string s, string t)
        //{
        //    int indexS = s.Length - 1;
        //    int indexT = t.Length - 1;

        //    while (indexS >= 0 || indexT >= 0)
        //    {
        //        indexS = CheckBackSpaceChar(s, indexS);

        //        indexT = CheckBackSpaceChar(t, indexT);

        //        if (indexS >= 0 && indexT >= 0 && s[indexS] != t[indexT])
        //            return false;
        //        else if (indexS < 0 && indexT < 0)
        //            break;

        //        if (indexS >= 0)
        //            indexS--;
        //        if (indexT >= 0)
        //            indexT--;
        //    }

        //    return indexS < 0 && indexT < 0;
        //}

        //public static int CheckBackSpaceChar(string s, int index)
        //{
        //    if (index < 0)
        //        return index;

        //    if (s[index] == '#')
        //    {
        //        var count = 1;
        //        while (s[index - count] == '#')
        //        {
        //            count++;
        //        }
        //        index -= count * 2;
        //    }

        //    return index;
        //}
    }
}
