namespace PracticeExamples.Examples
{
    public class Palindrome
    {
        public bool isPalindrome(string s)
        {   
            s = s.ToLower();
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
