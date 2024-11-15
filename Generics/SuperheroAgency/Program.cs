namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 5, 2, 8, 6 };
            Console.WriteLine(GetLast(intArray)); // 6

            double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            Console.WriteLine(GetLast(doubleArray)); // 6.1111

            string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            Console.WriteLine(GetLast(stringArray));

        }

        static T GetLast<T>(ICollection<T> collection)
        {
            T[] array = collection.ToArray();
            return array[array.Length - 1];
        }
    }
}
