// See https://aka.ms/new-console-template for more information
using _net_version.Project;

var input = new ListNode(0);
//input.next = new ListNode(9);
//input.next.next = new ListNode(9);
//input.next.next.next = new ListNode(9);

var input2 = new ListNode(7);
input2.next = new ListNode(3);
//input2.next.next = new ListNode(9);

var result = LongestCommonPrefix.LongestCommonPrefix1(new string[] { "a", "cac", "bcba", "b", "ca" });
Console.WriteLine(result);
Console.ReadLine();
