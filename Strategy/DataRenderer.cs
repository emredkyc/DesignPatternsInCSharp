public class DataRenderer
{
    private IRenderStrategy _renderStrategy;

    // The render strategy can be set via the constructor or a setter method
    public DataRenderer(IRenderStrategy renderStrategy)
    {
        _renderStrategy = renderStrategy;
    }

    public void SetRenderStrategy(IRenderStrategy renderStrategy)
    {
        _renderStrategy = renderStrategy;
    }

    public string RenderData(string data)
    {
        return _renderStrategy.Render(data);
    }
}
