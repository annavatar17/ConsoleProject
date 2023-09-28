using System.Collections.Generic;

namespace ConsoleProject
{
    public static class StringExtension
    {
        public static bool IsMatchBrackets(this string str)
        {
            var stack = new Stack<char>();

            foreach (var character in str)
            {
                if (character == '<')
                {
                    stack.Push(character);
                }
                else if (stack.Count > 0 && character == '>')
                {
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
