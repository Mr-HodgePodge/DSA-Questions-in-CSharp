public class Program
{
    public static void Main(string[] args)
    {

        // String data structure and algorithm question where the question is to find the first non repeating character in a string
        // The best solution is the function FirstNonRepeatingCharacterSolutionTwo, with a time complexity of O(n) and a space complexity of O(1)
        // The space complexity is constant because we know the limit of possible characters is 26, and will not increase linearly
        // The time complexity is n + n = O(2n) = O(n)

        // Space O(1) | Time O(n^2)
        static int FirstNonRepeatingCharacterSolutionOne(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                bool found = false;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                        found = true;
                }
                if (!found)
                    return i;
            }
            return -1;
        }

        // Space O(1) | Time O(n)
        static int FirstNonRepeatingCharacterSolutionTwo(string str)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                    dict[str[i]] = -1;
                else
                    dict[str[i]] = i;
            }

            foreach (var kvp in dict)
            {
                if (kvp.Value != -1)
                    return kvp.Value;
            }

            return -1;
        }

        Console.WriteLine("Solution One");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionOne("abcdeabcde")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionOne("abcde")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionOne("abcdeabc")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionOne("faadabcbbebdf")}");

        Console.WriteLine($"\n -------------- \n");
        Console.WriteLine("Solution Two");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionTwo("abcdeabcde")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionTwo("abcde")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionTwo("abcdeabc")}");
        Console.WriteLine($"First non-repeating character is at index: {FirstNonRepeatingCharacterSolutionTwo("faadabcbbebdf")}");
    }
}