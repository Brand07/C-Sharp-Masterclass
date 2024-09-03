﻿// //Create an instance of the random class
// Random random = new Random();
// //1,11 because the last number is exclusive
// //This will generate a random number between 1 and 10.
// int randomNumber = random.Next(1, 11);
//
// //Prompt user for a number
// Console.WriteLine("Guess the number: ");
// //Store the user's reponse on the inputString
// string inputString = Console.ReadLine();
// int num1 = 0;
//
// bool isNumber = int.TryParse(inputString, out num1);
//
// if (isNumber)
// {
// 	if (num1 == randomNumber)
// 	{
// 		Console.WriteLine("You guessed the correct number!");
// 	}
// 	else
// 	{
// 		Console.WriteLine($"Sorry, do you didn't guess the correct number. The random number was {randomNumber} ");
// 	}
// }

Console.WriteLine("Enter your first number: ");
string num1 = Console.ReadLine();
Console.WriteLine("Enter your second number: ");
string num2 = Console.ReadLine();

//Ask the user what math operation they want to do.
Console.WriteLine("1: Addition\n2: Subtraction\n3: Multiplication\n4: Division ");
string userChoice = Console.ReadLine();

if (userChoice == "1")
{
	if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
	{
		int result = number1 + number2;
		Console.WriteLine($"{num1} + {num2} = {result}");
	}
	else
	{
		Console.WriteLine("Invalid input. Please enter valid numbers.");
	}
}
else if (userChoice == "2")
{
	if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
	{
		int result = number1 - number2;
		Console.WriteLine($"{num1} - {num2} = {result}");
	}
	else
	{
		Console.WriteLine("Invalid input. Please enter valid numbers.");
	}
	
}
else if (userChoice == "3")
{
	if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
	{
		int result = number1 * number2;
		Console.WriteLine($"{num1} * {num2} = {result}");
	}
	else
	{
		Console.WriteLine("Invalid input. Please enter a valid number.");
	}
}
else if (userChoice == "4")
	if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
	{
		if (number2 != 0)
		{
			int result = number1 / number2;
			Console.WriteLine($"{num1}/ {num2} = {result}");
		}
		else
		{
			Console.WriteLine("You cannot divide by zero.");
		}
	}
