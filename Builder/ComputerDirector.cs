public class ComputerDirector
{
    private IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructComputer()
    {
        _builder.BuildCPU();
        _builder.BuildRAM();
        _builder.BuildHardDrive();
        _builder.BuildGraphicsCard();
    }

    public Computer GetComputer()
    {
        return _builder.GetComputer();
    }
}
