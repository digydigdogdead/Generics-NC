namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Ferrari", "Testorossa", new CarEngine(), false);
            Motorcycle myBike = new Motorcycle("Yamaha", "E-Saxophone", new MotorcycleEngine(), true);

            myCar.StartEngine();
            myBike.StartEngine();

            myCar.Drive();
            myBike.Drive();


            ATV myATV = new ATV("ASDA", "StarQuad", new MotorcycleEngine(), true);
            myATV.ChangeTyres("tesco");
            myCar.ChangeTyres("Michelin");
        }
    }
}
