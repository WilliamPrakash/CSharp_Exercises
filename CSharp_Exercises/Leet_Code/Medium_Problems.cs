﻿using System;
using System.Text;
using System.Collections.Generic;

namespace CSharp_Exercises.Leet_Code;

public class Medium_Problems
{
    #region Unsolved Problems
    /* 12. Integer to Roman
    -Roman numerals are formed by appending the conversions of decimal
    place values from highest to lowest. Converting a decimal place
    value into a Roman numeral has the following rules:
    -If the value does not start with 4 or 9, select the symbol of the
    maximal value that can be subtracted from the input, append that
    symbol to the result, subtract its value, and convert the remainder
    to a Roman numeral.
    -If the value starts with 4 or 9 use the subtractive form representing
    one symbol subtracted from the following symbol, for example, 4 is 1
    (I) less than 5 (V): IV and 9 is 1 (I) less than 10 (X): IX. Only the
    following subtractive forms are used: 4 (IV), 9 (IX), 40 (XL), 90 (XC),
    400 (CD) and 900 (CM).
    -Only powers of 10 (I, X, C, M) can be appended consecutively at most
    3 times to represent multiples of 10. You cannot append 5 (V), 50 (L),
    or 500 (D) multiple times. If you need to append a symbol 4 times use
    the subtractive form.
    
    Input: num = 3749
    Output: "MMMDCCXLIX"
    Explanation:
    3000 = MMM as 1000 (M) + 1000 (M) + 1000 (M)
     700 = DCC as 500 (D) + 100 (C) + 100 (C)
      40 = XL as 10 (X) less of 50 (L)
       9 = IX as 1 (I) less of 10 (X)
    Note: 49 is not 1 (I) less of 50 (L) because the conversion is based on decimal places */
    enum RomanInts
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
    public string IntToRoman(int num)
    {
        string numStr = "";
        /* Strategy:
        If num can be divided by an int, append enum counterpart to string */


        return numStr;
    }
    #endregion

    #region Solved Problems
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
            if (l3Temp.val + longest.val + nextDigitIncrement > 9)
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

    /* 3. Longest Substring Without Repeating Characters
    Given a string s, find the length of the longest substring without repeating characters.
    Input: s = "abcabcbb"
    Output: 3
    Input: s = "bbbb"
    Output: 1 */
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

    /* 78. Subsets
    Given an integer array nums of unique elements, return all possible subsets (the power set).
    The solution set must not contain duplicate subsets. Return the solution in any order. 

    Input: nums = [1,2,3]
    Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]] */
    // Recursive version of this would use "Backtracking"
    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> returnSubsets = new List<IList<int>>();
        List<IList<int>> subsetsToAdd = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Iterate over subsets
            if (returnSubsets.Count > 0)
            {
                foreach (List<int> subset in returnSubsets)
                {
                    List<int> copy = new List<int>(subset);
                    copy.Add(nums[i]);
                    subsetsToAdd.Add(copy);
                }
                returnSubsets.AddRange(subsetsToAdd);
                subsetsToAdd.Clear();
            }
            else
            {
                // Add blank and individual subsets for this number
                returnSubsets.Add(new List<int>() { });
                returnSubsets.Add(new List<int>() { nums[i] });
            }

        }
        return returnSubsets;
    }
    #endregion
}
