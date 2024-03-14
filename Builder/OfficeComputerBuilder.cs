public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "Mid-Range CPU";
    }

    public void BuildRAM()
    {
        _computer.RAM = "16GB";
    }

    public void BuildHardDrive()
    {
        _computer.HardDrive = "512GB SSD";
    }

    public void BuildGraphicsCard()
    {
        // Office computers might not need high-end graphics cards
        _computer.GraphicsCard = "Integrated Graphics";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}