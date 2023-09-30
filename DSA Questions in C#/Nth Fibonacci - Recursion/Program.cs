public class Program
{
    public static void Main(string[] args)
    {
        static int GetNthFib(int n)
        {
            if (n == 0 || n == 1)
                return 0;
            if (n == 2)
                return 1;
            else
                return GetNthFib(n - 1) + GetNthFib(n - 2);
        }

        Console.WriteLine($"The 6th number in the fibonacci sequence is: {GetNthFib(6)}");
    }
}