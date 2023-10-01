public class Program
{
    public static void Main(string[] args)
    {

        // Algorithm question using recursion and memoization to find the probability of a dealer hand busting in blackjack.
        // The best solution is the function BlackjackProbability (with helper function), with a time complexity of O(t - s) and a space complexity of O(t - s)

        static float BlackjackProbability(float target, float startingHand)
        {
            var dict = new Dictionary<float, float>();

            return (float)Math.Round(calculateProbability(target, startingHand, dict), 3);
        }

        static float calculateProbability(float target, float currentHand, Dictionary<float, float> dict)
        {
            if (dict.ContainsKey(currentHand))
                return dict[currentHand];
            if (currentHand > target)
                return 1;
            if (currentHand + 4 >= target)
                return 0;

            float probability = 0f; 
            for (int i = 1; i < 11; i++)
                probability += 0.1f * calculateProbability(target, currentHand + i, dict);
            dict[currentHand] = probability;

            return probability;
        }

        float[] arr = { 15f };

        foreach (float hand in arr) 
            Console.WriteLine($"The probability of a dealer hand {hand} busting is: {BlackjackProbability(21f, hand)}");
    }
}