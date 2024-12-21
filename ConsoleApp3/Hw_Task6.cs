public class Hw_Task6
{
    public Func<string, string, bool> ContainsWord = (text, word) =>
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word))
        {
            return false;
        }

        return text.Contains(word);
    };
}
