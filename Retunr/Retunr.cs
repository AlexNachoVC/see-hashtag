namespace Return
{
    public class ReturnClass
    {
        public static void Explore()
        {
            Console.WriteLine(Multiply(1, 5));
        }

        static double Multiply(double one, double two)
        {
            return one * two;
        }
    }
}