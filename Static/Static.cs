namespace Static
{
    public class StaticClass
    {
        public static void Explore()
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();
        }
    }

    class Car
    {
        string model;
        public static int numberOfCars;
        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}