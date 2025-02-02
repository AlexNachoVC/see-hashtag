namespace Arithmetic
{
    public class ArithmeticClass
    {
        static public void Explore()
        {
            int friends = 5;

            // friends = friends + 1; not prefered style for dotnet
            friends++; // prefered syntax for one digit change in dotnet
            friends += 2; // prefered dotnet syntax (compound assignment) for changes greater than one digit

            // the same for subtractions
            friends = friends - 1;
            friends--;
            friends -= 1;
            

            friends = friends * 2;
            friends *= 2; // also, prefered dotnet syntax is using the compount assignment

            // the same preferences for division
            friends = friends / 2;
            friends /= 2;

            // modulus
            int remainder = friends % 3;

            Console.WriteLine(friends);
            Console.WriteLine(remainder);
        }
    }
}