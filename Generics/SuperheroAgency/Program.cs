namespace SuperheroAgency;

internal class Program
{
    static void Main(string[] args)
    {
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

        //Console.WriteLine(myBooks.Pop()); // Book 3
        //Console.WriteLine(myBooks.Length());

        var strandedCat = new RescueMission<IFly>("tree", 50);
        var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
        var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);

        var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD, 13, 5000, 3);
        strandedCat.HeroesDeployed.Add(reyzhen); // All good

        var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL, "Regular belt that holds up trousers", 8);

        static T GetLast<T>(ICollection<T> collection)
        {
            T[] array = collection.ToArray();
            return array[array.Length - 1];
        }
    }
}
