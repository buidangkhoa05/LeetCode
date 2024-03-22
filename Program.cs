// See https://aka.ms/new-console-template for more information
using LeetCode.Project;

var input = new ListNode(0);
//input.next = new ListNode(9);
//input.next.next = new ListNode(9);
//input.next.next.next = new ListNode(9);

var input2 = new ListNode(7);
input2.next = new ListNode(3);
//input2.next.next = new ListNode(9);

var result = ValidParentheses.IsValidParentheses("()[]{}");
Console.WriteLine(result);
Console.ReadLine();
