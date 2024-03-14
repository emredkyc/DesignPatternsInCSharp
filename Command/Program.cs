/* This example demonstrates how to apply the Command pattern for undo/redo functionality 
 * in a text editor, encapsulating each edit operation within command objects. 
 * This allows for flexible and extensible editing features, 
 * such as implementing new types of edit operations without modifying the core editor logic. */

Document document = new Document();
CommandManager commandManager = new CommandManager();

// Simulate text editing
commandManager.ExecuteCommand(new InsertTextCommand(document, "Hello, ", 0));
commandManager.ExecuteCommand(new InsertTextCommand(document, "World!", 7));
Console.WriteLine(document); // Output: Hello, World!

// Undo last insert
commandManager.Undo();
Console.WriteLine(document); // Output: Hello, 

// Redo last insert
commandManager.Redo();
Console.WriteLine(document); // Output: Hello, World!

// Perform delete
commandManager.ExecuteCommand(new DeleteTextCommand(document, 0, 5));
Console.WriteLine(document); // Output: , World!

// Undo delete
commandManager.Undo();
Console.WriteLine(document); // Output: Hello, World!