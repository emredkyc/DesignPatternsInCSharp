/* This example demonstrates how the Builder pattern can be used to construct complex objects. 
 * By changing the builder, you can produce different representations of the object 
 * (in this case, different types of computers) using the same construction process. */

IComputerBuilder gamingBuilder = new GamingComputerBuilder();
ComputerDirector director = new ComputerDirector(gamingBuilder);

director.ConstructComputer();
Computer gamingComputer = director.GetComputer();
Console.WriteLine("Gaming Computer: " + gamingComputer);

IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director = new ComputerDirector(officeBuilder);

director.ConstructComputer();
Computer officeComputer = director.GetComputer();
Console.WriteLine("Office Computer: " + officeComputer);