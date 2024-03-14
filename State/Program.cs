/* In this example, TextEditor uses different ITextState implementations 
 * to alter how text is formatted based on the current state. 
 * When the state changes (e.g., to bold or italic), the TypeText method 
 * formats the text according to the rules defined in the current state. 
 * This approach cleanly separates the concerns of text formatting from the 
 * editor logic, making it easy to add new styles or modify existing ones
 * without changing the TextEditor class. */

TextEditor editor = new TextEditor();

// Typing in normal state
Console.WriteLine(editor.TypeText("This is normal text."));

// Change state to bold
editor.SetState(new BoldTextState());
Console.WriteLine(editor.TypeText("This is bold text."));

// Change state to italic
editor.SetState(new ItalicTextState());
Console.WriteLine(editor.TypeText("This is italic text."));