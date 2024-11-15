using System.Data.Common;

namespace SuperheroAgency;

public abstract class Mission<T> 
{
    public string Location { get; private set; }
    public int Reward { get; private set; }

    public List<T> HeroesDeployed { get; } = new List<T>();
    
    public Mission(string location, int reward)
    {
        Location = location;
        Reward = reward;
    }
}
