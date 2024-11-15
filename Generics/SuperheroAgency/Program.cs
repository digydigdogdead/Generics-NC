namespace SuperheroAgency;

internal class Program
{
    static void Main(string[] args)
    {
        //// First Collection Task

        //static T GetLast<T>(ICollection<T> collection)
        //{
        //    T[] array = collection.ToArray();
        //    return array[array.Length - 1];
        //}


        //// First Stack Task

        //Stack<string> stack = new Stack<string>();
        //stack.Push("Hardboiled wonderland and the end of the world");
        //stack.Push("The Three-Body Problem");
        //stack.Push("Batman/Elmer Fudd crossover");
        //stack.Pop();
        //Console.WriteLine(stack.Count);

        //foreach (var item in stack)
        //{
        //    Console.WriteLine(item);
        //}

        //var myBooks = new CustomStack<string>();

        //myBooks.Push("Book 1");
        //myBooks.Push("Book 2");
        //myBooks.Push("Book 3");


        //// Superheroes, Part One

        //Console.WriteLine(myBooks.Pop()); // Book 3
        //Console.WriteLine(myBooks.Length());

        //var strandedCat = new RescueMission<IFly>("tree", 50);
        //var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
        //var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);

        //var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD, 13, 5000, 3);

        //strandedCat.HeroesDeployed.Add(reyzhen); // All good


        //// Superheroes, Part Two

        //var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD, 13, 5000, 3);

        //var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL, "Regular belt that holds up trousers", 8);

        //var survey1 = new ReconMission<Gadgeteer>("Leeds", 300); // Should provide an error

        //var survey2 = new ReconMission<Mystic>("Manchester", 300);

        //survey2.HeroesDeployed.Add(reyzhen); // All good
        //survey2.HeroesDeployed.Add(rich); // Should provide an error


        //// Updated CustomStack Task

        //CustomStack<string> gameStack = new CustomStack<string>();
        //gameStack.Push("Hades");
        //gameStack.Push("Subnautica");
        //gameStack.Push("FTL");
        //gameStack.Pop();
        //Console.WriteLine(gameStack.Count());

        //foreach (var item in gameStack)
        //{
        //    Console.WriteLine(item);
        //}


        // Expanded Superhero Agency Task

        Mystic chris = new Mystic("Chris", "Chris", 42, Alignment.EVIL, 42, 42, 42);
        Mystic chris2 = new Mystic("Chris2", "Chris", 42, Alignment.EVIL, 42, 42, 1);
        Gadgeteer carlyle = new Gadgeteer("Carlyle", "Laurent", 18, Alignment.GOOD, "A live frog", 4);

        SuperheroAgency carlylesAgency = new SuperheroAgency();
        carlylesAgency.Add(chris);
        carlylesAgency.Add(chris2);
        carlylesAgency.Add(carlyle);

        ReconMission<IFly> testMission = new ReconMission<IFly>("Prague", 2000, 10);

        testMission.HeroesDeployed.Add(chris2);
        carlylesAgency.PerformMission(testMission);
        Console.WriteLine(carlylesAgency.AgencyFunds);

        testMission.HeroesDeployed.Add(chris);
        carlylesAgency.PerformMission(testMission);
        Console.WriteLine(carlylesAgency.AgencyFunds);

        carlylesAgency.PerformMission(testMission);
        Console.WriteLine(carlylesAgency.AgencyFunds);
    }
}
