string secretWord = "Princey"; // my cat 
string guess = "";
int guessCount = 0;
int guessLimit = 10;
bool outOfGuesses = false;

while (guess != secretWord && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {
        Console.Write("Enter guess: ");
        guess = Console.ReadLine();
        guessCount++;

        int numMatches = 0;
        for (int i = 0; i < guess.Length && i < secretWord.Length; i++)
        {
            if (guess[i] == secretWord[i])
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
            Console.WriteLine("Hint: The first letter of the secret word is {0}.", secretWord[0]);
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



