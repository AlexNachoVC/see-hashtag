namespace GettersSetters
{
    public class GettersSettersClass
    {
        public static void Explore()
        {
            Car car = new Car(400);

            car.Speed = 700;

            Console.WriteLine(car.Speed);
        }   
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}