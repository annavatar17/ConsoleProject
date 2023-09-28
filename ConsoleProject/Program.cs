using System;

namespace ConsoleProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the string to check or enter done to end: ");

                var input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }
                else
                {
                    var isMatch = input.IsMatchBrackets();
                    Console.WriteLine($"Brackets matched?: {isMatch}\n");
                }
            }
        }
    }
}
