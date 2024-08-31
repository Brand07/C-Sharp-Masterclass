//Introduction to Logic in C#
/*
 * 1 - Logical Operators such as AND, OR, NOT
 * 2 - Comparative Operators such as equal to, greater than, less than, etc
 * 3 - Combining Expressions - combine boolean (true or false) expressions
*/
// Boolean statement
bool isRainy = false;
bool isSunny = true;

// Logical Operators:
// AND &&
// OR ||
// NOT !

// If statement using AND
if (isRainy && isSunny)
{
 Console.WriteLine("Its going to be humid!");
}
// If statement using OR
if (isRainy || isSunny)
{
 Console.WriteLine("There will certainly be a mixture of weather today.");
}
// If statement using NOT
if (!isRainy)
{
 Console.WriteLine("There will be no rain today.");
}

// Relational operators > <
int num1 = 5;
int num2 = 6;
bool isHigher = num1 > num2;

int age = 28;
if (age >= 18)
{
 Console.WriteLine("Go vote!");
}




