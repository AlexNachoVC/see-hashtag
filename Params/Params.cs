namespace Params
{
    public class ParamsClass
    {
        public static void Explore()
        {
            double total = Checkout(3.99, 5.75, 75, 24);
            Console.WriteLine(total);
        }

        static double Checkout(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    } 
}