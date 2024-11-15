namespace SuperheroAgency;

public class ReconMission<T> : Mission<T> where T : IFly
{
    public ReconMission(string location, int reward, int difficulty) : base(location, reward, difficulty)
    {
    }
}
