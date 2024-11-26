using System;
using System.Collections;

namespace CSharp_Exercises.LeetCode.Easy
{
	
	public class Easy_Problems
	{
        /* 1. Two Sum
			Given an array of integers nums and an integer target, return indices of the
			two numbers such that they add up to target.

			You may assume that each input would have exactly one solution,
			and you may not use the same element twice.

			You can return the answer in any order.

			Input: nums = [2,7,11,15], target = 9
			Output: [0,1]

			Input: nums = [3,2,4], target = 6
			Output: [1,2]

			Input: nums = [3,3], target = 6
			Output: [0,1]
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

        


        /* 20. Valid Parentheses
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
			// Add each digit to a string
			/*string numStr = "";
			for (int i = 0; i < digits.Length ; i++)
			{
				numStr += digits[i].ToString();
			}
			numStr = (Int64.Parse(numStr) + 1).ToString();
			// Increase digits' length by 1
			digits = new int[numStr.Length];
			for (int i = 0; i < numStr.Length; i++)
			{
				var x = Int64.Parse(numStr[i].ToString());
				digits[i] = (int)Int64.Parse(numStr[i].ToString());
				Console.WriteLine(digits);
			}*/

			return digits;
		}
    }
}

