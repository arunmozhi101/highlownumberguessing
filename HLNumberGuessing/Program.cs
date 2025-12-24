const int MAXIMUM_ATTEMPTS = 7;

Console.WriteLine("Welcome to the High Low Number Guessing Program!");
Console.WriteLine("Press any key to continue...");
Console.ReadLine();

while (true)
{
    Console.Clear();
    Random rng = new Random();
    int randomNumber = rng.Next(0, 10);

    Console.WriteLine("Computer: Guess the number I have in my mind.");
    Console.WriteLine($"You've a maximum of {MAXIMUM_ATTEMPTS} attempts.");

    for (int attemptsRemaining = MAXIMUM_ATTEMPTS; attemptsRemaining > 0; attemptsRemaining--)
    {
        int guessedNumber = Convert.ToInt32(Console.ReadLine());
        int diff = guessedNumber - randomNumber;

        if (diff == 0)
        {
            switch (attemptsRemaining)
            {
                case > 3:
                    Console.WriteLine($"OMG! You guessed it in only {MAXIMUM_ATTEMPTS - attemptsRemaining} attempts! Are you Psychic?");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;

                case > 1:
                    Console.WriteLine($"Well done! You guessed it in {MAXIMUM_ATTEMPTS - attemptsRemaining} attempts!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;

                case > 0:
                    Console.WriteLine("Finally!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }

            break;
        }

        if (diff >= -5 && diff <= 5)
        {
            Console.WriteLine("You're close!");
        }

        if (diff > 5)
        {
            Console.WriteLine("Too High!");
        }

        if (diff < -5)
        {
            Console.WriteLine("Too Low!");
        }

        if ((attemptsRemaining - 1) > 0)
        {
            Console.WriteLine($"You've {attemptsRemaining - 1} attempts remaining.");
        }
        else
        {
            Console.WriteLine($"Sorry you used up all the attempts. Here is the number I guessed - {randomNumber}");
            Console.WriteLine($"Good Luck next time!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}