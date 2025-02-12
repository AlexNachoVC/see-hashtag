namespace ArrayOfObjects
{
    public class ArrayOfObjectsClass
    {
        public static void Explore()
        {
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            

            Car[] garage2 = { new Car("Ferrari"), new Car("BMW"), new Car("Porsche") }; // this way, these are anonymous objects

            foreach (Car car in garage2)
            {
                Console.WriteLine(car.model);
            }
        }
    }

    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}