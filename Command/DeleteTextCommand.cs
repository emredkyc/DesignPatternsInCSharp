public class DeleteTextCommand : ICommand
{
    private string _deletedText;
    private Document _document;
    private int _position; // Position from which text was deleted

    public DeleteTextCommand(Document document, int position, int length)
    {
        _document = document;
        _position = position;
        _deletedText = _document.GetText(position, length);
    }

    public void Execute()
    {
        _document.Delete(_position, _deletedText.Length);
    }

    public void Undo()
    {
        _document.Insert(_position, _deletedText);
    }
}
