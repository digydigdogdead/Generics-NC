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
}
