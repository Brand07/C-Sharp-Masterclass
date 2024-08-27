// datatype variableName = initial value;
Console.WriteLine("Enter a whole number: ");
//int myNumber = 0;

//string userInput = Console.ReadLine();
//myNumber = int.Parse(userInput);
//Console.WriteLine($"You entered {myNumber}.");

// Actual addition calculator

int firstNumber = 0;
int secondNumber = 0;

// Store the first number
string firstNumberInput = Console.ReadLine();
// Parse the first number
firstNumber = int.Parse(firstNumberInput);
// Prompt the user for the second number
Console.WriteLine("Enter another whole number; ");
// Store the second number
string secondNumberInput = Console.ReadLine();
// Parse the second number
secondNumber = int.Parse(secondNumberInput);

// Add the firstNumber and secondNumber
int result = firstNumber + secondNumber;
Console.WriteLine(result);
