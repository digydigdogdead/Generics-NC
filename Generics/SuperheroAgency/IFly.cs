namespace SuperheroAgency;

public interface IFly
{
    public double FlightSpeed { get; set; }
    public double MaxHeight { get; set; }

    public void Fly(string alias)
    {
        Console.WriteLine($"{alias} swoops by look at them go!");
    }
}
