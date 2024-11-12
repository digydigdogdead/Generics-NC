namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Ferrari", "Testorossa", new CarEngine());
            Motorcycle myBike = new Motorcycle("Yamaha", "E-Saxophone", new MotorcycleEngine(), true);

            myCar.StartEngine();
            myBike.StartEngine();

            myCar.Drive();
            myBike.Drive();
        }
    }
}
