//Introduction to Logic in C#
/*
 * 1 - Logical Operators such as AND, OR, NOT
 * 2 - Comparative Operators such as equal to, greater than, less than, etc
 * 3 - Combining Expressions - combine boolean (true or false) expressions
*/
// Boolean statement
bool isRainy = false;
bool isSunny = true;

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


// Logical Operators:
// AND &&
// OR ||
// NOT !