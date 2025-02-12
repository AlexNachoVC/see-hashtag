namespace Constructors
{
    public class ConstructorsClass 
    {
        public static void Explore()
        {
            Car car1 = new Car("Ford", "Mustang", 2022, "red");

            car1.Drive();

            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car2.Drive();
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

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        } 
    }

    
}