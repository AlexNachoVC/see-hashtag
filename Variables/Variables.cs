namespace Variables
{
    public class VariablesClass
    {
        public static void Explore()
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 19;
            double height = 180.5;
            bool alive = true;
            char symbol = '@';
            String name = "Alejandro";
            String userName = symbol + name;

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");

            if (alive)
            {
                Console.WriteLine("You are alive");
            }
            else
            {
                Console.WriteLine("traca");
            }

            Console.WriteLine("Your symbol is: " + symbol);

            Console.WriteLine("Your username is: " + userName);

            /*Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z); 
            */
        }
    }
}