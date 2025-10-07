using System;
namespace Recursion_2333960
{
	public class Recursion
	{
		public static bool DNATest(string dnaString)
		{
			if(dnaString.Length <= 1)
			{
				return true;
			}

			if (dnaString[0] == dnaString[dnaString.Length-1])
			{
				return DNATest(dnaString.Substring(1, dnaString.Length-2));
			}
			else
			{
				return false;
			}

        }

	}
}
