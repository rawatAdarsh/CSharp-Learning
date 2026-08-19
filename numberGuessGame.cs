int secretNumber = 7;
int attempts = 0;
int guessedCorrectly = 0;
while (attempts < 3 && guessedCorrectly == 0)
{
    Console.Write($"Guess the secret number (between 1 and 10): ");
    int guess = int.Parse(Console.ReadLine());
    if (guess == secretNumber)
    {
        Console.WriteLine($"Congratulations! You guessed the secret number, which is: {secretNumber}");
        guessedCorrectly = 1;
    } 
    else
    {
        Console.WriteLine($"Incorrect guess. Try again.");
        attempts++;

    }
    
}
if(guessedCorrectly == 1)
{
    Console.WriteLine($"You won!");
}
else
{
    Console.WriteLine($"You Lost!");
    Console.WriteLine($"Sorry, you have used all your attempts.");
}

//Console.WriteLine($"Game Over");
//Console.WriteLine($"Sorry, you have used all your attempts. The secret number was: {secretNumber}");
