/*
Author: Brandon Yates
Date: 9/16/2024
*/

// Break and Continue
for (int i = 0; i < 10; i++)
{
	Console.WriteLine(i);
	if (i == 3)
	{
		Console.WriteLine("I've had enough");
		continue;
	}
	Console.WriteLine("Only if not continued");
}