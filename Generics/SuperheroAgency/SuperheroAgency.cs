namespace SuperheroAgency;

public class SuperheroAgency
{
    public List<Superhero> AllSuperheroes { get; set; } = new List<Superhero>();
    
    private int _agencyFunds = 0;
    public int AgencyFunds { get => _agencyFunds; }

    public void PerformMission<T>(Mission<T> mission)
    {
        if (mission.IsCompleted)
        {
            Console.WriteLine("Mission already complete. Go do something else, you lazy bums!");
            return;
        }

        int currentStrength = 0;
        foreach (T hero in mission.HeroesDeployed)
        {
            if (hero is IStrength)
            {
                currentStrength += ((IStrength)hero).StrengthLevel;
            }
            else if (hero is ITelepathy)
            {
                currentStrength += ((ITelepathy)hero).PowerLevel;
            }
        }

        bool isSuccessful = currentStrength >= mission.Difficulty;

        mission.ResolveMission(ref _agencyFunds, isSuccessful);
    }

    public void PerformMission(HackingMission<ITech> mission)
    {
        if (mission.IsCompleted)
        {
            Console.WriteLine("Mission already complete. Go do something else, you lazy bums!");
            return;
        }

        int currentStrength = 0;
        foreach (ITech hero in mission.HeroesDeployed)
        {
            currentStrength += hero.HackingLevel;
        }

        bool isSuccessful = currentStrength >= mission.Difficulty;

        mission.ResolveMission(ref _agencyFunds, isSuccessful);
    }

    public void Add(Superhero superhero)
    {
        AllSuperheroes.Add(superhero);
    }

    public void Add(IEnumerable<Superhero> superheroes)
    {
        AllSuperheroes.AddRange(superheroes);
    }

    public List<Superhero> GetSuperheroesByPowers<T>()
    {
        return AllSuperheroes.Where(s => s is T).ToList();
    }

    public List<Superhero> GetSuperheroesByPowers<T, U>()
    {
        return AllSuperheroes.Where(s => s is T && s is U).ToList();
    }

    public List<Superhero> GetSuperheroesByAlignment(Alignment alignment)
    {
        return AllSuperheroes.Where(s => s.Alignment == alignment).ToList();
    }

    public void PrintAllMonologues()
    {
        foreach (var superhero in AllSuperheroes)
        {
            Console.WriteLine($"{superhero.Alias}: \"" + superhero.Monologue() + "\"");
        }
    }
}
