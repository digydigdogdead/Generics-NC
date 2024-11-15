namespace SuperheroAgency;

public class HackingMission<T> : Mission<T> where T : ITech
{
    public HackingMission(string location, int reward) : base(location, reward)
    {
    }
}
