namespace SuperheroAgency;

public class Tank : Superhero, IFly, IStrength
{
    public double FlightSpeed { get; set; }
    public double MaxHeight { get; set; }
    public int StrengthLevel { get; set; }

    public Tank(string secretIdentity, string alias, int age, Alignment alignment,
                double flightSpeed, double maxHeight, int strengthLevel)
        : base(secretIdentity, alias, age, alignment)
    {
        FlightSpeed = flightSpeed;
        MaxHeight = maxHeight;
        StrengthLevel = strengthLevel;
    }

    public override string Monologue()
    {
        if (this.Alignment == Alignment.GOOD)
        {
            return "I can shield all these innocent citizens from harm using my bulky body.";
        }
        else
        {
            return "I totally *could* shield these citizens, as my body is very bulky, but I won't, because I'm actually evil.";
        }
    }
}
