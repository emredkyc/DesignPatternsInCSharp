public abstract class Document
{
    protected IRenderer renderer;

    public Document(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract string Render();
}
