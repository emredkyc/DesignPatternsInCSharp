public class ItalicTextState : ITextState
{
    public string HandleInput(string text)
    {
        return "*" + text + "*"; // Markdown-style italic
    }
}
