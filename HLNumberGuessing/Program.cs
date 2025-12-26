const int MAXIMUM_ATTEMPTS = 7; // Maximum number of attempts a user has to guess the random number.
const int TOO_CLOSE_VALUE = 5; // If the guess is close to the random number by this number then is it too close.
const int RANGE_MIN_VALUE = 1;
const int RANGE_MAX_VALUE = 101;


Console.WriteLine("Welcome to the High Low Number Guessing Program!");
Console.WriteLine("Press any key to continue...");
Console.ReadLine();

while (true)
{
    Console.Clear();
    Random rng = new Random();
    int randomNumber = rng.Next(RANGE_MIN_VALUE, RANGE_MAX_VALUE);

    int attemptsThatUserWonOn = 0;
    int userWonOrLost = 0; // 0 = Lost and 1 = Won

    Console.WriteLine("Computer: Guess the number I have in my mind.");
    Console.WriteLine($"You've a maximum of {MAXIMUM_ATTEMPTS} attempts.");

    for (int attemptsRemaining = MAXIMUM_ATTEMPTS; attemptsRemaining > 0; attemptsRemaining--)
    {
        int guessedNumber = Convert.ToInt32(Console.ReadLine());
        int diff = guessedNumber - randomNumber;

        if (diff == 0)
        {
            userWonOrLost = 1;
            attemptsThatUserWonOn = MAXIMUM_ATTEMPTS - attemptsRemaining;
            break;
        }

        if (diff >= -TOO_CLOSE_VALUE && diff <= TOO_CLOSE_VALUE)
        {
            Console.WriteLine("You're close!");
        }

        if (diff > TOO_CLOSE_VALUE)
        {
            Console.WriteLine("Too High!");
        }

        if (diff < -TOO_CLOSE_VALUE)
        {
            Console.WriteLine("Too Low!");
        }

        if ((attemptsRemaining - 1) > 0)
        {
            Console.WriteLine($"You've {attemptsRemaining - 1} attempts remaining.");
        }
    }

    if (userWonOrLost == 1)
    {
        switch (MAXIMUM_ATTEMPTS - attemptsThatUserWonOn)
        {
            case > 3:
                Console.WriteLine(
                    $"OMG! You guessed it in only {attemptsThatUserWonOn} attempts! Are you Psychic?");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                break;

            case > 1:
                Console.WriteLine($"Well done! You guessed it in {attemptsThatUserWonOn} attempts!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                break;

            case > 0:
                Console.WriteLine("Finally!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                break;
        }
    }
    else
    {
        Console.WriteLine($"Sorry you used up all the attempts. Here is the number I guessed - {randomNumber}");
        Console.WriteLine($"Good Luck next time!");
    }
    
    Console.WriteLine("Do you want to continue playing?(Y/N)");
    string continuePlay = Console.ReadLine().ToLower();
    if (continuePlay == "n")
    {
        Console.WriteLine($"Thanks for playing the High Low Number Guessing Game!");
        break;
    }
}