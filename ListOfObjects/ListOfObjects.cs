namespace ListOfObjects
{
    public class ListOfObjectsClass
    {
        public static void Explore()
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Pepe");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            players.Add(new Player("uno"));
            players.Add(new Player("dos"));
            players.Add(new Player("tres"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}