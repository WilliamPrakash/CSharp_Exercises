using CSharp_Exercises.Data_Structures;
using CSharp_Exercises.LeetCode.Easy;
using CSharp_Exercises.LeetCode.Medium;


/* Objects */
Easy_Problems easyProblems = new Easy_Problems();
Medium_Problems mediumProblems = new Medium_Problems();

Medium_Problems.ListNode l1 = new Medium_Problems.ListNode(9);
l1.next = new Medium_Problems.ListNode(9);
l1.next.next = new Medium_Problems.ListNode(9);
l1.next.next.next = new Medium_Problems.ListNode(9);
l1.next.next.next.next = new Medium_Problems.ListNode(9);
l1.next.next.next.next.next = new Medium_Problems.ListNode(9);
l1.next.next.next.next.next.next = new Medium_Problems.ListNode(9);

Medium_Problems.ListNode l2 = new Medium_Problems.ListNode(9);
l2.next = new Medium_Problems.ListNode(9);
l2.next.next = new Medium_Problems.ListNode(9);
l2.next.next.next = new Medium_Problems.ListNode(9);
mediumProblems.AddTwoNumbers(l1, l2);

/*Medium_Problems.ListNode l1 = new Medium_Problems.ListNode(9);
l1.next = new Medium_Problems.ListNode(9);
l1.next.next = new Medium_Problems.ListNode(1);

Medium_Problems.ListNode l2 = new Medium_Problems.ListNode(1);
mediumProblems.AddTwoNumbers(l1, l2);*/

/*Medium_Problems.ListNode l1 = new Medium_Problems.ListNode(2);
l1.next = new Medium_Problems.ListNode(4);
l1.next.next = new Medium_Problems.ListNode(3);

Medium_Problems.ListNode l2 = new Medium_Problems.ListNode(5);
l2.next = new Medium_Problems.ListNode(6);
l2.next.next = new Medium_Problems.ListNode(4);*/
mediumProblems.AddTwoNumbers(l1, l2);
