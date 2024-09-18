/*
Topic: Arrays
Author: Brandon Yates
Date: 9/17/2024
*/


// Declare an array and set the array values
int[] myIntArray = [5, 34, 34, 12, 45];


//Access an item in the array
Console.WriteLine(myIntArray[3]); //Should print 12 in the console


//Declare an array with the days of the week
string[] weekdays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];

//Foreach loop to loop through the days of the week
foreach (string day in weekdays)
{
	Console.WriteLine($"Today is {day}");
}

//Two-dimensional array
int[,] array2DDeclaration = new int[3, 3]; //Think X and Y axis

// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]


