using System;
using System.Collections;

namespace CSharp_Exercises.Leet_Code;

public class Easy_Problems
{
    #region Unsolved Problems
    #endregion

    #region Solved Problems
    /* 1. Two Sum
	Given an array of integers nums and an integer target, return indices of the
	two numbers such that they add up to target.
	You may assume that each input would have exactly one solution,
	and you may not use the same element twice.
	Input: nums = [2,7,11,15], target = 9
	Output: [0,1]
	Input: nums = [3,2,4], target = 6
	Output: [1,2] */
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
	Input: -121, Output: false */
	public bool IsPalindrome(int x)
	{
		// Negatives can't be palindromes
		if (x < 0) { return false; }

		// Break int arg into digit array
		char[] xCharArray = x.ToString().ToCharArray();
		List<int> xIntArray = new List<int>();
		for (int i = 0; i < xCharArray.Length; i++)
		{
			xIntArray.Add(xCharArray[i] - '0'); // (int)xCharArray[i] and Convert.ToInt32(xCharArray[i]) work too
		}

		// If odd number of ints, remove the middle
		if (xIntArray.Count % 2 == 1 && xIntArray.Count > 1)
		{
			xIntArray.RemoveAt(xIntArray.Count % 2);
		}
		else if (xIntArray.Count == 0)
		{
			return true;
		}
		//Console.WriteLine(xIntArray);

		// Remove from front and back, and compare
		int front = 0;
		int back = xIntArray.Count - 1;
		while (front < xIntArray.Count - 1)
		{
			if (xIntArray[front] != xIntArray[back]) { return false; }
			front++;
			back--;
		}

		return true;
	}


	/* 20. Valid Parentheses
	Given a string s containing just the characters
	'(', ')', '{', '}', '[' and ']', determine if
	the input string is valid. */
	public bool IsValid(string s)
	{
		// Short java solution - phoenix12steve
		Stack<char> brackets = new Stack<char>();
		for (int i = 0; i < s.Length; i++)
		{
			// If opening bracket, push closing bracket onto stack
			if (s[i] == '(') brackets.Push(')');
			else if (s[i] == '{') brackets.Push('}');
			else if (s[i] == '[') brackets.Push(']');
			// take closing brackets and compare it to 
			else if (brackets.Count == 0 || brackets.Pop() != s[i]) return false;
		}

		return brackets.Count == 0;
	}

    /* 66. Plus One
	Given a large int represented as in int array, increment
	the large int by 1 and return the resulting array
	of digits 
	Input: digits = [1,2,3]
	Output: [1,2,4] 
	Increment the large integer by one and return the resulting array of digits. */
    public int[] PlusOne(int[] digits)
    {
        int end = digits.Length - 1;

        while (end > -1 && (digits[end] + 1) > 9)
        {
            digits[end] = 0;
            end--; // move to front of digits[]
        }

        // Still need to increment at this point
        // At end of 9+1 digit incrementation (if any)
        if (end == -1 && digits[0] == 0)
        {
            // Need to add a 1 to the front
            int[] front = { 1 };
            return front.Concat(digits).ToArray();
        }
        else // not at beginning of digits
        {
            digits[end] += 1;
        }

        //Console.WriteLine("");

        return digits;
    }
    #endregion
}
