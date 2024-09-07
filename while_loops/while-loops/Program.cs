// The While Loop

// For loop as an example
Console.WriteLine("For Loop:");
for (int i = 0; i < 10; i++)
{
	Console.WriteLine(i);
}

// While Loop example
Console.WriteLine("Enter 'go' or 'stay'.");

string userChoice = Console.ReadLine();

while (userChoice == "go")
{
	Console.WriteLine($"I was thinking {userChoice} too!");
	Console.WriteLine("Want to keep going? Enter 'go'.");
	userChoice = Console.ReadLine();
} 


