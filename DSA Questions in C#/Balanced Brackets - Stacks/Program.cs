public class Program
{
    public static void Main(string[] args)
    {

        // Stack data structure and algorithm question where the question is to test whether list of brackets is balanced
        // Note that all operations done within the list are constant time (comparison, push, pop)

        // Space O(n) | Time O(n)
        static bool BalancedBracketsSolutionOne(string str)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (list.Count == 0 && (str[i] == ')' || str[i] == ']' || str[i] == '}'))
                    return false;
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                    list.Add(str[i]);
                if (str[i] == ')')
                {
                    if (list.Last() == '(')
                        list.RemoveAt(list.Count - 1);
                    else
                        return false;
                }
                if (str[i] == ']')
                {
                    if (list.Last() == '[')
                        list.RemoveAt(list.Count - 1);
                    else
                        return false;
                }
                if (str[i] == '}')
                {
                    if (list.Last() == '{')
                        list.RemoveAt(list.Count - 1);
                    else
                        return false;
                }
            }
            if (list.Count != 0)
                return false;
            return true;
        }

        Console.WriteLine($"Balanced: {BalancedBracketsSolutionOne("({[]})")}");
        Console.WriteLine($"Balanced: {BalancedBracketsSolutionOne("))({[]})")}");
        Console.WriteLine($"Balanced: {BalancedBracketsSolutionOne("[((([])([]){}){}){}([])[]((())")}");
    }
}