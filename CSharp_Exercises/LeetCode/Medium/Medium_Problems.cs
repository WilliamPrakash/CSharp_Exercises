using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercises.LeetCode.Medium
{
    public class Medium_Problems
    {
        /* 2. Add Two Numbers
			You are given two non-empty linked lists representing two non-negative integets. The digits are stored in reverse order,
			and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
			You may assume the two numbers do not contain any leading zero, except the number 0 itself.
			Input: l1 = [2,4,3], l2 = [5,6,4]
			Output: [7,0,8]
			Explanation: 342 + 465 = 807.
		 */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string temp = "";
            int total = 0;
            List<ListNode> list = new List<ListNode> { l1, l2 };

            /* Iterate through ListNode (Linked List) */
            list.ForEach(l =>
            {
                // Iterate through each element in the ListNode
                while (l != null)
                {
                    temp += l.val.ToString();
                    l = l.next;
                }
                Char[] numsAsChars = temp.ToCharArray(); // Only char arrays have the Reverse() function
                Array.Reverse(numsAsChars); // Returns void, operates on the original array
                temp = new string(numsAsChars);
                total += int.Parse(temp);
                temp = ""; // Wipe temp for next number
            });

            /* Convert int total back to ListNode (head of Linked List) */
            Char[] numsAsChar = total.ToString().ToCharArray(); // ASCII chars
            Array.Reverse(numsAsChar);
            int asciiIntConverted = (int)char.GetNumericValue(numsAsChar[0]); // Convert ASCII char to int
            ListNode head = new ListNode(asciiIntConverted);
            ListNode curr = head;

            // Break if there's only one element
            if (numsAsChar.Length <= 1)
            {
                return head;
            }

            /* Iterate over the rest of the chars(ints) */
            // This logic only works for 3 digits...
            /*for (int i = 1; i < numsAsChar.Length; i++)
            {
                while (curr.next != null)
                {
                    curr = curr.next;
                }

                asciiIntConverted = (int)char.GetNumericValue(numsAsChar[i]);
                curr.next = new ListNode(asciiIntConverted);
            }
            head.next = curr;*/

            return head;
        }
    }
}
