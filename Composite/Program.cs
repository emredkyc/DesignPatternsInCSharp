/* In this example, Panel acts as a composite object that can contain any 
 * number of GUIComponent objects, including other Panel objects. 
 * Both Button and TextBox are leaf objects.This structure allows you 
 * to build a complex GUI by nesting panels within each other and adding 
 * components to them, treating every component in the hierarchy 
 * uniformly through the common GUIComponent interface. */

// Create leaf components
GUIComponent button1 = new Button("Login");
GUIComponent textBox1 = new TextBox("Username");

// Create a composite component
Panel mainPanel = new Panel("MainPanel");
mainPanel.Add(button1);
mainPanel.Add(textBox1);

// Create another panel and add it to the main panel
Panel subPanel = new Panel("SubPanel");
subPanel.Add(new TextBox("Password"));
subPanel.Add(new Button("Cancel"));
mainPanel.Add(subPanel);

// Display the tree structure
mainPanel.Display(1);