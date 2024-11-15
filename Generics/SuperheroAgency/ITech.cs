namespace SuperheroAgency;

public interface ITech
{
    public string Gadget { get; set; }
    public int HackingLevel { get; set; }

    public void Hack(string alias)
    {
        Console.WriteLine($"{alias} is hacking into the mainframe!");
    }
}
