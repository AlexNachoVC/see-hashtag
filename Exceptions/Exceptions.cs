namespace Exception
{
    public class ExceptionClass
    {
        public static void Explore()
        {
            int x;
            int y;
            double result;

            try
            {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
        }
    }
}