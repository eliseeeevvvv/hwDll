namespace TextLibrary
{
    public static class TextHelper
    {
        public static bool IsPalindrome(string text)
        {
            string cleanText = text
                .Replace(" ", "")
                .ToLower();

            string reversed = Reverse(text);

            return cleanText == reversed;
        }

        public static int CountSentences(string text)
        {
            int count = 0;

            foreach (char symbol in text)
            {
                if (symbol == '.' || symbol == '!' || symbol == '?')
                {
                    count++;
                }
            }

            return count;
        }

        public static string Reverse(string text)
        {
            char[] chars = text.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }
    }
}