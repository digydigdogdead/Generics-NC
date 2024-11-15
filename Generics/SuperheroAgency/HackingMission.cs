namespace SuperheroAgency;

public class HackingMission<T> : Mission<T> where T : ITech
{
    public HackingMission(string location, int reward, int difficulty) : base(location, reward, difficulty)
    {
    }
}
