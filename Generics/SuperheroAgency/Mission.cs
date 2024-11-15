namespace SuperheroAgency;

public abstract class Mission<T> 
{
    public string Location { get; private set; }
    public int Reward { get; private set; }
    public bool IsCompleted { get; set; } = false;
    public int Difficulty { get; }

    public List<T> HeroesDeployed { get; } = new List<T>();
    
    public Mission(string location, int reward, int difficulty)
    {
        Location = location;
        Reward = reward;
        Difficulty = difficulty;
    }

    public void ResolveMission(ref int agencyFunds, bool isSuccessful)
    {
        if (isSuccessful)
        {
            this.IsCompleted = true;
            Console.WriteLine("Mission complete. Well done heroes.");
            agencyFunds += Reward;
        }
        else
        {
            Console.WriteLine("You failed. The hostages all exploded.");
        }
    }
}
