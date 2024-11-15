namespace SuperheroAgency;

public class Mystic : Superhero, IFly, ITelepathy
{
    public double FlightSpeed { get; set; }
    public double MaxHeight { get; set; }
    public int PowerLevel { get; set; }

    public Mystic(string secretIdentity, string alias, int age, Alignment alignment,
                  double flightSpeed, double maxHeight, int powerLevel)
        : base(secretIdentity, alias, age, alignment)
    {
        FlightSpeed = flightSpeed;
        MaxHeight = maxHeight;
        PowerLevel = powerLevel;
    }
}
