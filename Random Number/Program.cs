using System.Collections.Generic;

Random randomNumber = new Random();
int number = randomNumber.Next(1, 11);
string guess;
int numberGuess;
string playAgain = "Y";
List<int> numberOfGuesses = new List<int>();
do
{
    do
    {
        Console.Write("What's your guess? : ");
        guess = Console.ReadLine();
        numberGuess = int.Parse(guess);
        numberOfGuesses.Add(1);
    }while(numberGuess != number);
    if (numberGuess == number)
    {
        Console.WriteLine("Congrats, you guessed correctly!");
        Console.WriteLine($"You guessed {numberOfGuesses.Count()} times");
        Console.WriteLine("Would you like to play again? (Y/N) : ");
        playAgain = Console.ReadLine();
        numberOfGuesses.Clear();
    }
}while (playAgain != "N");