namespace While
{
    public class WhileClass
    {
        public static void Explore()
        {
            string name = "";

            while (name == "")
            {
                Console.WriteLine("Please, enter your name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Your name is: " + name);
        }
    }
}