namespace StringInterpolation
{
    public class StringInterpolationClass
    {
        public static void Explore()
        {
            string firstName = "AlexNacho";
            string lastName = "VC";
            int age = 19;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age, 10} years old."); // you can add the number of spaces after the variable inserted {age,10} with that format (negative number is left aligned and positive is right)
        }
    }
}