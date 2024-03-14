public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "High-End CPU";
    }

    public void BuildRAM()
    {
        _computer.RAM = "32GB";
    }

    public void BuildHardDrive()
    {
        _computer.HardDrive = "1TB SSD";
    }

    public void BuildGraphicsCard()
    {
        _computer.GraphicsCard = "High-End Graphics Card";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
