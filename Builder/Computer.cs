public class Computer
{
    public string? CPU { get; set; }
    public string? RAM { get; set; }
    public string? HardDrive { get; set; }
    public string? GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, Hard Drive: {HardDrive}, Graphics Card: {GraphicsCard}";
    }
}
