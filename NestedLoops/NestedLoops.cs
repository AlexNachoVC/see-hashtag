namespace NestedLoops
{
    public class NestedLoopsClass
    {
        public static void Explore()
        {
            Console.WriteLine("How many rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}