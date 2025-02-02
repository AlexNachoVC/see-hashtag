namespace HypothenuseCalculator
{
    public class HypothenuseCalculatorClass
    {
        public static void Explore()
        {
            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("The hypothenuse is: " + c);
        }
    }
}