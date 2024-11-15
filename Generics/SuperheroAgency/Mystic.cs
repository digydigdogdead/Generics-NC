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

    public override string Monologue()
    {
        if (this.Alignment == Alignment.GOOD)
        {
            return "Sometimes I hear people's secrets on accident, and I do my best to just forget them. That's none of my business.";
        }
        else
        {
            return "I like to give people phobias of things that they didn't have before.";
        }
    }
}
