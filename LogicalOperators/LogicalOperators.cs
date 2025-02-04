namespace LogicalOperators
{
    public class LogicalOperatorsClass
    {
        public static void Explore()
        {
            Console.WriteLine("What's the tempearature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("aguas");
            }
        }
    }
}