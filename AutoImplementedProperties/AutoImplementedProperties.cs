namespace AutoImplementedProperties
{
    public class AutoImplementedPropertiesClass
    {
        public static void Explore()
        {
            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        string model;

        public string Model { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }
    }
}