namespace AbstractClasses
{
    public class AbstractClassesClass
    {
        public static void Explore()
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            // Vehicle vehicle = new Vehicle();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}