namespace NumberGuessing
{
    public class NumberGuessingClass
    {
        public static void Explore()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.WriteLine("Choose a number between " + min + " and " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("Correct!");
                    }
                    
                }
                Console.WriteLine("You needed " + guesses + " guesses to find the correct number");

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "N")
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("\nThanks for playing!");
        }
    }
}