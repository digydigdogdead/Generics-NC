namespace SuperheroAgency;

public class SuperheroAgency
{
    public List<Superhero> AllSuperheroes { get; set; } = new List<Superhero>();

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
}
