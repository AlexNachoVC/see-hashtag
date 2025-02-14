namespace Lists
{
    public class ListsClass
    {
        public static void Explore()
        {
            List<string> food = new List<string>();

            food.Add("Pizza");
            food.Add("Hamburguer");
            food.Add("Hotdog");

            food.Remove("Hotdog");

            food.Insert(0, "Sushi");

            Console.WriteLine(food.Count);

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}