public class NormalTextState : ITextState
{
    public string HandleInput(string text)
    {
        return text; // Returns the text as is
    }
}
