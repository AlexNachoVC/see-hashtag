namespace ConditionalOperator
{
    public class ConditionalOperatorClass
    {
        public static void Explore()
        {
            double temperature = 20;
            string message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
            Console.WriteLine(message);
        }
    }
}