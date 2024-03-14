public class ReportDocument : Document
{
    private string title;
    private string body;
    private string footer;

    public ReportDocument(IRenderer renderer, string title, string body, string footer) : base(renderer)
    {
        this.title = title;
        this.body = body;
        this.footer = footer;
    }

    public override string Render()
    {
        var header = renderer.RenderHeader(title);
        var bodyContent = renderer.RenderBody(body);
        var footerContent = renderer.RenderFooter(footer);
        return $"{header}\n{bodyContent}\n{footerContent}";
    }
}
