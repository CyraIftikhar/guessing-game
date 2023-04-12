string secretWord = "strawberry";
string guess = " ";
int guessCount = 0;
int guessLimit = 10;
bool outOfGuesses = false;

while (guess.ToLower() != secretWord.ToLower() && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {
        Console.Write("Enter guess: ");
        guess = Console.ReadLine();
        guess = guess.ToLower();

        guessCount++;

        int numMatches = 0;
        for (int i = 0; i < guess.Length && i < secretWord.Length; i++)
        {
            if (guess[i].ToString().ToLower() == secretWord[i].ToString().ToLower())
            {
                numMatches++;
            }
        }

        if (numMatches == secretWord.Length)
        {
            Console.WriteLine("Congratulations, you guessed the word!");
        }
        else if (numMatches > 0)
        {
            Console.WriteLine("You're close! {0} letters match the secret word.", numMatches);
        }
        else
        {
            Console.WriteLine("Incorrect guess. Try again.");
        }

        if (guessCount == 3)
        {
            Console.WriteLine("Hint: It's a tasty red fruit.");
        }
    }
    else
    {
        outOfGuesses = true;
    }
}

if (outOfGuesses)
{
    Console.Write("You Lose");
}
else
{
    Console.Write("You Win!");
}

Console.ReadLine();

