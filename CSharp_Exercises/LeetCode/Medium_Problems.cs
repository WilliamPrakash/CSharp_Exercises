using System;
using System.Text;
using System.Collections.Generic;

namespace CSharp_Exercises.LeetCode
{
    public class Medium_Problems
    {
        #region Problem 2.
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
            ListNode l1Temp = l1, l2Temp = l2;
            ListNode shortest, longest;
            bool equal = false;

            // Find the shortest ListNode
            while (true)
            {
                if (l1Temp.next == null && l2Temp.next == null)
                {
                    equal = true;
                }

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

            ListNode l3Temp = new ListNode(), l3 = l3Temp;
            Boolean addOne = false;
            int nextDigitIncrement = 0;

            // Iterate over the shorter list, adding to the vals in
            // the longer list, while carrying the 1
            while (shortest != null)
            {
                // Check to see if we need to increment the next decimal place
                if (shortest.val + longest.val + nextDigitIncrement > 9)
                {
                    // If the total is greater than 10, subtract 10
                    if ((shortest.val + longest.val + nextDigitIncrement) > 10)
                    {
                        l3Temp.val = ((shortest.val + longest.val + nextDigitIncrement) - 10) % 10;
                    }
                    // Else, just take the remainder
                    else
                    {
                        l3Temp.val = (shortest.val + longest.val + nextDigitIncrement) % 10;
                    }
                    addOne = true;
                    nextDigitIncrement = 1;
                }
                else
                {
                    l3Temp.val = shortest.val + longest.val + nextDigitIncrement;
                    addOne = false;
                    nextDigitIncrement = 0;
                }
                
                // ONLY set up a new node at the end of the iteration if there's another node
                if (shortest.next != null)
                {
                    l3Temp.next = new ListNode();
                    l3Temp = l3Temp.next;
                }
                shortest = shortest.next;
                longest = longest.next;

            }

            // Add an extra node if one ListNode is longer
            if (!equal)
            {
                l3Temp.next = new ListNode();
                l3Temp = l3Temp.next;
            }

            // Iterate over the rest of the vals in longest (if any), carrying over
            // any that remainder that needs to be added.
            while (longest != null)
            {
                /* Why am I adding ltTemp.val in these calcs? */
                if (l3Temp.val +longest.val + nextDigitIncrement > 9)
                {
                    if ((l3Temp.val + longest.val + nextDigitIncrement) > 10)
                    {
                        l3Temp.val = (10 % (l3Temp.val + longest.val + nextDigitIncrement) - 10);
                    }
                    else
                    {
                        l3Temp.val = (l3Temp.val + longest.val + nextDigitIncrement) % 10;
                    }
                    addOne = true;
                    nextDigitIncrement = 1;
                }
                else
                {
                    l3Temp.val = l3Temp.val + longest.val + nextDigitIncrement;
                    addOne = false;
                    nextDigitIncrement = 0;
                }

                // Only add another Node if there's another val in Longest
                if (longest.next != null)
                {
                    l3Temp.next = new ListNode();
                    l3Temp = l3Temp.next;
                }
                longest = longest.next;
            }

            // Remainder gets carried to last digit
            if (addOne)
            {
                l3Temp.next = new ListNode(nextDigitIncrement);
            }
            
            return l3;
        }
        #endregion

        #region Problem 3.
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
            List<char> uniqueSubString = new List<char>();
            int longestLength = 0;
            // pwwkew -> wke

            for (int i = 0; i <= charArr.Length - 1; i++)
            {
                for (int j = i; j <= charArr.Length - 1; j++)
                {
                    if (!uniqueSubString.Contains(charArr[j]))
                    {
                        uniqueSubString.Add(charArr[j]);
                    }
                    // issue: this is only adding up the longestLength 
                    else
                    {
                        if (uniqueSubString.Count > longestLength)
                        {
                            longestLength = uniqueSubString.Count;
                        }
                        break;
                    }
                }
                if (uniqueSubString.Count > longestLength)
                {
                    longestLength = uniqueSubString.Count;
                }
                uniqueSubString.Clear();
            }

            return longestLength;
        }
        #endregion

    }
}
