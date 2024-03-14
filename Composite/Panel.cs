public class Panel : GUIComponent
{
    private List<GUIComponent> children = new List<GUIComponent>();

    public Panel(string name) : base(name) { }

    public void Add(GUIComponent component)
    {
        children.Add(component);
    }

    public void Remove(GUIComponent component)
    {
        children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + " Panel: " + name);
        // Recursively display child nodes
        foreach (var component in children)
        {
            component.Display(depth + 2);
        }
    }
}
