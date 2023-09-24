public class Program
{
    static void Main(string[] args)
    {

        // String data structure and algorithm question where the question is to test whether a particular string is a palindrome
        // The best solution is the function IsPalindromeSolutionFour, with a time complexity of O(N) and a space complexity of O(1)
        // Strings in C# are immutable, and whenever a value is appended to a string, a new one is creating in memory...
        // ...with a time complexity of O(N) and a memory complexity of O(N)

        static bool IsPalindromeSolutionOne(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string reverseStr = new string(charArr);

            if (str == reverseStr)
                return true;
            return false;
        }

        static bool IsPalindromeSolutionTwo(string str)
        {
            string reverseStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }

            if (str == reverseStr)
                return true;
            return false;
        }

        static bool IsPalindromeSolutionThree(string str)
        {
            if (str.Length <= 1)
                return true;
            if (str[0] == str[str.Length - 1])
                return IsPalindromeSolutionThree(str.Substring(1, str.Length - 2));
            return false;
        }

        static bool IsPalindromeSolutionFour(string str)
        {
            int leftIdx = 0;
            int rightIdx = str.Length - 1;
            while (leftIdx < rightIdx)
            {
                if (str[leftIdx] != str[rightIdx])
                    return false;
                leftIdx++;
                rightIdx--;
            }
            return true;
        }

        string stringOne = "abcde";
        string stringTwo = "abcdcba";

        bool testOneSolutionOne = IsPalindromeSolutionOne(stringOne);
        bool testTwoSolutionOne = IsPalindromeSolutionOne(stringTwo);

        Console.WriteLine("Solution One");

        Console.WriteLine($"{stringOne} is a palindrome: {testOneSolutionOne}");
        Console.WriteLine($"{stringTwo} is a palindrome: {testTwoSolutionOne}");

        bool testOneSolutionTwo = IsPalindromeSolutionTwo(stringOne);
        bool testTwoSolutionTwo = IsPalindromeSolutionTwo(stringTwo);

        Console.WriteLine("Solution Two");

        Console.WriteLine($"{stringOne} is a palindrome: {testOneSolutionTwo}");
        Console.WriteLine($"{stringTwo} is a palindrome: {testTwoSolutionTwo}");

        bool testOneSolutionThree = IsPalindromeSolutionThree(stringOne);
        bool testTwoSolutionThree = IsPalindromeSolutionThree(stringTwo);

        Console.WriteLine("Solution Three");

        Console.WriteLine($"{stringOne} is a palindrome: {testOneSolutionThree}");
        Console.WriteLine($"{stringTwo} is a palindrome: {testTwoSolutionThree}");

        bool testOneSolutionFour = IsPalindromeSolutionFour(stringOne);
        bool testTwoSolutionFour = IsPalindromeSolutionFour(stringTwo);

        Console.WriteLine("Solution Four");

        Console.WriteLine($"{stringOne} is a palindrome: {testOneSolutionFour}");
        Console.WriteLine($"{stringTwo} is a palindrome: {testTwoSolutionFour}");
    }
}
