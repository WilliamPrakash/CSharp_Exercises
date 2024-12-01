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
            ulong total = 0;
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
                total += ulong.Parse(temp);
                temp = ""; // Wipe temp for next number
            });

            /* Convert int total to char array */
            Char[] numsAsChar = total.ToString().ToCharArray(); // ASCII chars
            Array.Reverse(numsAsChar);
            List<ListNode> totalListNodes = new List<ListNode>();

            /* Create ListNode for each char and add to a list */
            for(int i = 0; i < numsAsChar.Length; i++)
            {
                totalListNodes.Add(new ListNode( (int)char.GetNumericValue(numsAsChar[i]) ) );
            }

            //ListNode head = new ListNode(totalListNodes[0].val);

            /* Chain list of ListNodes together */
            for (int i = 0; i < totalListNodes.Count - 1; i++)
            {
                totalListNodes[i].next = totalListNodes[i+1];
            }

            //Console.WriteLine(totalListNodes);

            return totalListNodes[0];
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
