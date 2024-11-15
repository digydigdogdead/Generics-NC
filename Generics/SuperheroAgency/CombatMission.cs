namespace SuperheroAgency;

public class CombatMission<T> : Mission<T>
{
    public CombatMission(string location, int reward, int difficulty) : base(location, reward, difficulty)
    {
    }
}