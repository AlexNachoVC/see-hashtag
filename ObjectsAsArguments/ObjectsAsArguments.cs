namespace ObjectsAsArguments
{
    public class ObjectsAsArgumentsClass
    {
        public static void Explore()
        {
            Car car1 = new Car("Mustang", "Red");

            Car car2 = Copy(car1);

            Console.WriteLine(car2.color + " " + car2.model);
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    public class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}