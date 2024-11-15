namespace SuperheroAgency;

public interface ITelepathy
{
    public int PowerLevel { get; set; }

    public void ReadMind(string alias)
    {
        Console.WriteLine($"{alias} is reading your thoughts!");
    }
}
