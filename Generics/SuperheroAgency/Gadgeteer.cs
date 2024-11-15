namespace SuperheroAgency;

public class Gadgeteer : Superhero, ITech, IStrength
{
    public string Gadget { get; set; }
    public int StrengthLevel { get; set; }

    public Gadgeteer(string secretIdentity, string alias, int age, Alignment alignment,
                     string gadget, int strengthLevel)
        : base(secretIdentity, alias, age, alignment)
    {
        Gadget = gadget;
        StrengthLevel = strengthLevel;
    }
}
