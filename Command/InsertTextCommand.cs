public class InsertTextCommand : ICommand
{
    private string _textToInsert;
    private Document _document;
    private int _position; // Position at which text is inserted

    public InsertTextCommand(Document document, string text, int position)
    {
        _document = document;
        _textToInsert = text;
        _position = position;
    }

    public void Execute()
    {
        _document.Insert(_position, _textToInsert);
    }

    public void Undo()
    {
        _document.Delete(_position, _textToInsert.Length);
    }
}
