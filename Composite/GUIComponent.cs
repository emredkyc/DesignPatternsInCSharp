public abstract class GUIComponent
{
    protected string name;

    public GUIComponent(string name)
    {
        this.name = name;
    }

    public abstract void Display(int depth);
}
