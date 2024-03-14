public class TextEditor
{
    private ITextState _currentState;

    public TextEditor()
    {
        _currentState = new NormalTextState(); // Default state
    }

    public void SetState(ITextState newState)
    {
        _currentState = newState;
    }

    public string TypeText(string text)
    {
        return _currentState.HandleInput(text);
    }
}
