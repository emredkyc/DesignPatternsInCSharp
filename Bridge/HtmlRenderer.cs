public class HtmlRenderer : IRenderer
{
    public string RenderHeader(string text)
    {
        return $"<h1>{text}</h1>";
    }

    public string RenderBody(string text)
    {
        return $"<p>{text}</p>";
    }

    public string RenderFooter(string text)
    {
        return $"<footer>{text}</footer>";
    }
}
