namespace Switches
{
    public class SwitchesClass
    {
        public static void Explore()
        {
            Console.WriteLine("What day is today?");
            string day = Console.ReadLine();
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("It is Monday!");
                    break;
                case "tuesday":
                    Console.WriteLine("It is Tuesday!");
                    break;
                case "wednesday":
                    Console.WriteLine("It is Wednesday!");
                    break;
                case "thursday":
                    Console.WriteLine("It is Thursday!");
                    break;
                case "friday":
                    Console.WriteLine("It is Friday!");
                    break;
                case "saturday":
                    Console.WriteLine("It is Saturday!");
                    break;
                case "sunday":
                    Console.WriteLine("It is Sunday!");
                    break;
                default:
                    Console.WriteLine("woops");
                    break;
            }
        }
    }
}