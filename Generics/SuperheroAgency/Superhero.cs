namespace SuperheroAgency;

public abstract class Superhero
{
    private string SecretIdentity { get; }
    public string Alias { get; }
    public int Age { get; }
    public Alignment Alignment { get; }

    public Superhero(string secretIdentity, string alias, int age, Alignment alignment)
    {
        SecretIdentity = secretIdentity;
        Alias = alias;
        Age = age;
        Alignment = alignment;
    }
}
