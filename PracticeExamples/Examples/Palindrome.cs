namespace PracticeExamples.Examples
{
    public class Palindrome
    {
        public bool isPalindrome(string s)
        {
            s = s.ToLower();
            char[] c = s.ToCharArray();
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (c[i] != c[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
