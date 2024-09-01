//Equality operators

using System.Security.Cryptography;

/*
int num1 = 0;
int num2 = 0;

//Checks for equality
bool isEqual = num1 == num2; // true
//Checks for inequality
bool isNotEqual = num1 != num2; // false

Console.WriteLine("Enter a whole number: ");
if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal.");
    Console.WriteLine("What is your age? ");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("You've won a prize!");
    }
    else
    {
        Console.WriteLine("You're too young to claim a prize.");
    }
} 
else 
{
    Console.WriteLine("Numbers are not eqaul.");
}

*/
Console.WriteLine("How old are you? ");
int age = int.Parse(Console.ReadLine());
#pragma warning disable IDE0059 // Unnecessary assignment of a value
bool isWithParents = false;
#pragma warning restore IDE0059 // Unnecessary assignment of a value

if (age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with your parents? Answer with Y or N. ");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "y")
    {
        Console.WriteLine("Go party with your parents!");
    }
    else
    {
        Console.WriteLine("No party for you today.");
    }
}
else 
{
    Console.WriteLine("No party");
}

