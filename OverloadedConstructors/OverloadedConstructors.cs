namespace OverloadedConstructors
{
    public class OverloadedConstructorsClass
    {
        public static void Explore()
        {
            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella");

            pizza1.Display();
            pizza2.Display();
        }
    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public void Display()
        {
            Console.WriteLine(this.bread);
            Console.WriteLine(this.sauce);
            Console.WriteLine(this.cheese);
            Console.WriteLine(this.topping);
            Console.WriteLine();
        }
    }
}
