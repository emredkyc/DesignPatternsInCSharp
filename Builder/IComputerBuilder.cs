public interface IComputerBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildHardDrive();
    void BuildGraphicsCard();
    Computer GetComputer();
}
