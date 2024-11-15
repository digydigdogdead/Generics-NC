namespace SuperheroAgency;

public interface IStrength
{
    public int StrengthLevel { get; set; }

    public void Lift(string alias)
    {
        Console.WriteLine($"{alias} lifts with all their might!");
    }
}