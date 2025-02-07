namespace Methods
{
    public class MethodsClass
    {
        public static void Explore()
        {
            string name = "alguien";
            HappyBirthday(name);
        }

        static void HappyBirthday(string name)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name + "!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}