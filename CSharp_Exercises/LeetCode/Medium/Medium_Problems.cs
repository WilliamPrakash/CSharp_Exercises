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
			You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order,
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
            // Error in last version: Unhandled exception. System.OverflowException: Value was either too large or too small for a UInt64.

            // [2,4,3,8]  [5,6,4]
            // [7,0,8,8]

            ListNode l1Temp = l1, l2Temp = l2;
            ListNode shortest, longest;

            // Find shortest ListNode
            while (true)
            {
                if (l1Temp.next == null)
                {
                    shortest = l1;
                    longest = l2;
                    break;
                }
                else if (l2Temp.next == null)
                {
                    shortest = l2;
                    longest = l1;
                    break;
                }
                l1Temp = l1Temp.next;
                l2Temp = l2Temp.next;
            }

            // Reset temp ListNodes
            l1Temp = l1;
            l2Temp = l2;

            // Iterate over the shorter list, adding the elements to a new ListNode
            ListNode l3Temp = new ListNode();
            ListNode l3 = l3Temp;
            Boolean addOne = false;
            int nextDigitIncrement = 0;
            while (shortest != null)
            {
                if (addOne == true) nextDigitIncrement = 1;
                // Check to see if the sum of the two ListNode values is greater than 10
                if (shortest.val + longest.val + nextDigitIncrement > 9)
                {
                    l3Temp.val = 10 % (shortest.val + longest.val + nextDigitIncrement);
                    addOne = true; // add one to the next digit
                }
                else
                {
                    l3Temp.val = shortest.val + longest.val + nextDigitIncrement;
                }
                l3Temp.next = new ListNode();
                l3Temp = l3Temp.next;
                shortest = shortest.next;
                longest = longest.next;
            }
            Console.WriteLine(l3);
            

            // Add the rest of the vals in longest
            while (longest != null)
            {
                //l3Temp = new ListNode(longest.val);
                l3Temp = new ListNode(longest.val);
                l3Temp = l3Temp.next;
                longest = longest.next;
            }
            // Add l3Temp to l3?
            Console.WriteLine(l3);

            return l3;
        }

        /* 3. Longest Substring Without Repeating Characters
            Given a string s, find the length of the longest substring without repeating characters.
            Input: s = "abcabcbb"
            Output: 3
            Input: s = "bbbb"
            Output: 1
        */
        public int LengthOfLongestSubstring(string s)
        {
            char[] charArr = s.ToCharArray();
            List<char> substring = new List<char>();
            int longestLength = 0;

            // Iterate over each char in the string
            foreach (char c in charArr)
            {
                // If the char isn't in the substring, add it
                // Upon duplicate, 
                if (!substring.Contains(c))
                {
                    substring.Add(c);
                }
                else
                {

                }
            }

            return longestLength;
        }

    }
}
