namespace ToString
{
    public class ToStringClass
    {
        public static void Explore()
        {
            Car car = new Car("Chevy", "Corvette", 2022, "Blue");

            Console.WriteLine(car.ToString());
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}