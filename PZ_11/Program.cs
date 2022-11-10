namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(" .,!?:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
                if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]) && word.Length > 1)
                    count++;
            Console.WriteLine(count);
        }
    }
}