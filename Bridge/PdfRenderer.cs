public class PdfRenderer : IRenderer
{
    public string RenderHeader(string text)
    {
        return $"PDF Header: {text}";
    }

    public string RenderBody(string text)
    {
        return $"PDF Body: {text}";
    }

    public string RenderFooter(string text)
    {
        return $"PDF Footer: {text}";
    }
}
