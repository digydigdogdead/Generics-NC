namespace SuperheroAgency;

public class Gadgeteer : Superhero, ITech
{
    public string Gadget { get; set; }
    public int HackingLevel { get; set; }

    public Gadgeteer(string secretIdentity, string alias, int age, Alignment alignment,
                     string gadget, int hackingLevel)
        : base(secretIdentity, alias, age, alignment)
    {
        Gadget = gadget;
        HackingLevel = hackingLevel;
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
