﻿string secretWord = "Princey"; // my cat 
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


