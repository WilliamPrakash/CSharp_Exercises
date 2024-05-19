using System;
using System.Collections;

namespace CSharp_Exercises.LeetCode.Easy
{
	
	public class Easy_Problems
	{
        /* 66. Plus One
			Given a large int represented as in int array, increment
			the large int by 1 and return the resulting array
			of digits
		*/
		public int[] PlusOne(int[] digits)
		{
			string numStr = "";
			// add nums to string
			for (int i = 0; i < digits.Length ; i++)
			{
				numStr += digits[i].ToString();
			}
			numStr = (Int16.Parse(numStr) + 1).ToString();
			for (int i = 0; i < digits.Length; i++)
			{
				digits[i] = Int16.Parse(numStr[i].ToString());
			}

			return digits;
		}
    }
}

