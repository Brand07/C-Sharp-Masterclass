// The While Loop

// For loop as an example
// Console.WriteLine("For Loop:");
// for (int i = 0; i < 10; i++)
// {
// 	Console.WriteLine(i);
// }
//
// // While Loop example
// Console.WriteLine("Enter 'go' or 'stay'.");
//
// string userChoice = Console.ReadLine();
//
// while (userChoice == "go")
// {
// 	Console.WriteLine($"I was thinking {userChoice} too!");
// 	Console.WriteLine("Want to keep going? Enter 'go'.");
// 	userChoice = Console.ReadLine();
// } 

// Guess the number game using while loop(s)

int secretNumber = 42;
int userGuess = 0;

Console.WriteLine("Guess the number I'm thinking between 1 and 100: ");

while (userGuess != secretNumber)
{
	//Console.WriteLine("Wrong. Try again.");
	userGuess = int.Parse(Console.ReadLine());
	if (userGuess < secretNumber)
	{
		Console.WriteLine("Too Low.");
	}
	else if (userGuess > secretNumber)
	{
		Console.WriteLine("Too High.");
	}
	else if (userGuess == secretNumber)
	{
		userGuess = secretNumber;
		Console.WriteLine("Correct!");
	}
}



