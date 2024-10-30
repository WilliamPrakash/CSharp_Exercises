using CSharp_Exercises.LeetCode.Easy;
using CSharp_Exercises.Data_Structures;


Easy_Problems easyProblems = new Easy_Problems();

// Initialize first linked list
Easy_Problems.ListNode l1 = new Easy_Problems.ListNode(2);
l1.next = new Easy_Problems.ListNode(4);
l1.next.next = new Easy_Problems.ListNode(3);

// Initialize second Linked list
Easy_Problems.ListNode l2 = new Easy_Problems.ListNode(5);
l2.next = new Easy_Problems.ListNode(6);
l2.next.next = new Easy_Problems.ListNode(4);

easyProblems.AddTwoNumbers(l1, l2);

