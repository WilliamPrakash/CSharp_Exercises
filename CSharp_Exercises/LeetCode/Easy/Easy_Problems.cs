using System;
using System.Collections;

namespace CSharp_Exercises.LeetCode.Easy
{
	
	public class Easy_Problems
	{
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

