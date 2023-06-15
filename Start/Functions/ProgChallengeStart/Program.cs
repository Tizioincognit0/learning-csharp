using System;
using System.Collections.Generic;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin!");

            do
            {
                String str = Console.ReadLine();
                if ("exit".Equals(str))
                {
                    break;
                }
                (bool, int) result = IsPalindrome(str);
                Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");

            } while (8 == 8);

        }

        static (bool result, int length) IsPalindrome(String str)
        {
            String upperStr = str.ToUpper();
            String filteredStr = "";
            char[] upperCharsArray = { 'A', 'B', 'C', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> upperCharsArrayList = new();
            upperCharsArrayList.AddRange(upperCharsArray);

            foreach (char c in upperStr)
            {
                if (upperCharsArrayList.Contains(c))
                {
                    filteredStr += c;
                }
            }

            String revFilteredStr = "";
            for (int i = filteredStr.Length - 1; i != -1; i--)
            {
                revFilteredStr += filteredStr[i];
            }

            bool isPalindrome = filteredStr.Equals(revFilteredStr);
            return (isPalindrome, isPalindrome ? str.Length : 0);
        }
    }
}
