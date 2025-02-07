namespace MethodOverloading
{
    public class MethodOverloadingClass
    {
        public static void Explore()
        {
            Console.WriteLine(Multiply(1.5, 3.5));
            Console.WriteLine(Multiply(1, 7));
            Console.WriteLine(Multiply(1.5, 2.5, 3.5));
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}