/*
Author: Brandon Yates
Date: 9/16/2024
*/

// Average Calculator

int currentScore;
int sum = 0;
int counter = 0;

do
{
	Console.WriteLine("Enter your student's scores. Enter -1 to finish.");
	currentScore = int.Parse(Console.ReadLine());
	if (currentScore != -1)
	{
		sum = sum + currentScore;
		//Count the itterations
		counter++;
	}
	
} while (currentScore != -1);
// Find the average score
int average = sum / counter;
Console.WriteLine($"Your student's average score is: {average}");
