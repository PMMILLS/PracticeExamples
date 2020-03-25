using System.Collections.Generic;

namespace PracticeExamples.Examples
{
    public class BalancedBrackets
    {
        private Stack<char> stack;
        private Dictionary<char, char> brackets;

        public BalancedBrackets()
        {
            stack = new Stack<char>();
            brackets = new Dictionary<char, char>
            {
                {'}', '{'}, {']', '['}, {')', '('}
            };
        }

        public bool isBalanced(string s)
        {
            if (s == "" || s == null)
                return false;

            foreach(char c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                    stack.Push(c);

                else if (stack.Count > 0 && (brackets.GetValueOrDefault(c) == stack.Peek()))
                    stack.Pop();
                else
                    return false;
            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}