public class TextBox : GUIComponent
{
    public TextBox(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + " TextBox: " + name);
    }
}