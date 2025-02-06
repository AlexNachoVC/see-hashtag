namespace ForEach
{
    public class ForEachClass
    {
        public static void Explore()
        {
            string[] cars = { "BMW", "Corvette", "Porsche" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}