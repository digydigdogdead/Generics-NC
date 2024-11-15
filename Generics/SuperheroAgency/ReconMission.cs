namespace SuperheroAgency;

public class ReconMission<T> : Mission<T> where T : IFly
{
    public ReconMission(string location, int reward) : base(location, reward)
    {
    }
}
