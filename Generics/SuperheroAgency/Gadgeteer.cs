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

    public override string Monologue()
    {
        if (this.Alignment == Alignment.GOOD)
        {
            return "These gadgets will contribute to global sustainable farming.";
        } else
        {
            return "These gadgets will primarily be used to poison water supplies, mostly just cus I think that's funny. I'm evil.";
        }
    }
}
