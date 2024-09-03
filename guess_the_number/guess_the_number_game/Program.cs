//Create an instance of the random class
Random random = new Random();
//1,11 because the last number is exclusive
//This will generate a random number between 1 and 10.
int randomNumber = random.Next(1, 11);

//Prompt user for a number
Console.WriteLine("Guess the number: ");
//Store the user's reponse on the inputString
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
	if (num1 == randomNumber)
	{
		Console.WriteLine("You guessed the correct number!");
	}
	else
	{
		Console.WriteLine($"Sorry, do you didn't guess the correct number. The random number was {randomNumber} ");
	}
}
