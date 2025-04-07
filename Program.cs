namespace N7__YP__Task_8_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("input string : ");
            string  input = Console.ReadLine();

            Console.Write("input prefix : ");
            string prefix = Console.ReadLine();

            string[] words = input.Split([' ', '\t', '\r'], StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.StartsWith(prefix))
                {
                    Console.Write($"{word}");
                }
            }
        }
    }
}
