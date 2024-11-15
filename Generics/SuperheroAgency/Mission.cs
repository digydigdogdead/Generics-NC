using System.Data.Common;

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

    public void PerformMission()
    {
        int completeness = 0;
        foreach (var hero in HeroesDeployed)
        {
            if (hero is IStrength)
            {
                completeness += ((IStrength)hero).StrengthLevel;
            } else if (hero is ITelepathy)
            {
                completeness += ((ITelepathy)hero).PowerLevel;
            }
        }

        if (completeness >= Difficulty) { this.IsCompleted = true; }

        if (IsCompleted) Console.WriteLine("Mission complete. Well done heroes.");
        if (!IsCompleted) Console.WriteLine("You failed. The hostages all exploded.");
    }
}
