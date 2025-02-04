using System;
using System.Collections;

namespace CSharp_Exercises.LeetCode.Easy
{
	
	public class Easy_Problems
	{
        /* 1. Two Sum ***Solved
			Given an array of integers nums and an integer target, return indices of the
			two numbers such that they add up to target.
			You may assume that each input would have exactly one solution,
			and you may not use the same element twice.
			Input: nums = [2,7,11,15], target = 9
			Output: [0,1]
			Input: nums = [3,2,4], target = 6
			Output: [1,2]
		*/
        public int[] TwoSum(int[] nums, int target)
		{
			int difference = 0;
			int[] indexes = { 0, 0 };

			for (int i = 0; i < nums.Length; i++)
			{
                // Find the first number that is < the target
                if (nums[i] < target)
				{
					indexes[0] = i;
					difference = target - nums[i];
					//now loop through the rest of the ints looking for difference
					for (int j = i + 1; j < nums.Length; j++)
					{
						if (nums[j] == difference)
						{
							indexes[1] = j;
							Console.WriteLine("");
							i = nums.Length; //we need to fully break out of these loops
                            break;
						}
					}
				}
			}
			
			return indexes;
		}

        /* 9. Palindrome Number
			Given an integer x, return true if x is a palindrome, and false otherwise.
			Input: 121, Output: true
			Input: -121, Output: false
         */
		public bool IsPalindrome(int x)
		{
			// All negatives aren't palindromes
			if (x < 0) { return false; }

			// Break int arg into digit array
			// Is there a more efficient way to do this?
			char[] xChar = x.ToString().ToCharArray();
			int[] xArray = new int[xChar.Length];
			for (int i = 0; i < xChar.Length; i++)
			{
                xArray[i] = xChar[i] - '0'; // (int)xChar[i] and Convert.ToInt32(xChar[i]) work too
                i++;
            }


            Console.WriteLine();

			// LINQ version of what's above
            // int[] result = yourInt.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray()

            return true;
		}


        /* 20. Valid Parentheses ***Solved
			Given a string s containing just the characters
			'(', ')', '{', '}', '[' and ']', determine if
			the input string is valid.
		*/
        public bool IsValid(string s)
		{
			// Short java solution - phoenix12steve
			Stack<char> brackets = new Stack<char>();
			for (int i = 0; i < s.Length; i++)
			{
				// If opening bracket, push closing bracket onto stack
				if (s[i] == '(') brackets.Push(')');
				else if (s[i] == '{') brackets.Push('}');
                else if (s[i] == '[') brackets.Push (']');
				// take closing brackets and compare it to 
                else if (brackets.Count == 0 || brackets.Pop() != s[i]) return false;
            }

			return brackets.Count == 0;
		}


		/* 66. Plus One
			Given a large int represented as in int array, increment
			the large int by 1 and return the resulting array
			of digits
		*/
		public int[] PlusOne(int[] digits)
		{
			return digits;
		}
    }
}

