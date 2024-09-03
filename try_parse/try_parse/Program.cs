Console.WriteLine("Give me a number");
string inputString = Console.ReadLine(); 
int num1;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
	Console.WriteLine("Well done - you actually entered a number.");
}
else
{
	Console.WriteLine("You should have entered a number.");
}

num1++;
Console.WriteLine($"User entered number + 1 {num1}");