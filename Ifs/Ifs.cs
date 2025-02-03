namespace Ifs
{
    public class IfsClass
    {
        public static void Explore()
        {
            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();

            if (age == "")
            {
                Console.WriteLine("Please enter a valid age");
                return;
            }

            int ageNumber = Convert.ToInt32(age);

            if (ageNumber >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (ageNumber < 0)
            {
                Console.WriteLine("What");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
        }
    }
}