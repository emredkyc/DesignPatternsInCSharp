public class Button : GUIComponent
{
    public Button(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + " Button: " + name);
    }
}
