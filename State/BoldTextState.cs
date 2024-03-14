public class BoldTextState : ITextState
{
    public string HandleInput(string text)
    {
        return "**" + text + "**"; // Markdown-style bold
    }
}
