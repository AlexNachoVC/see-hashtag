namespace Arrays
{
    public class ArraysClass
    {
        public static void Explore()
        {
            // string[] cars = new string[sixe]; "This for declare an array and then assign values to it"

            string[] cars = { "BMW", "Mustang", "Ferrari" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

    }
}