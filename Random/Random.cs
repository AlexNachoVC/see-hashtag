namespace RandomNumber
{
    public class RandomNumberClass
    {
        public static void Explore()
        {
            Random random = new Random();

            int num1 = random.Next(1, 7); // returns a non-negative random integer, >= 0 and < int32.MaxValue (or whatever params you define in its args)
            int num2 = random.Next(1, 7); // we can use only one instantiation of the class, to generate various numbers
            int num3 = random.Next(1, 7);

            double nums = random.NextDouble(); // returns a random floating point integer >= 0.0 and < 1.0

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

        }
    }
}