//Equality operators

using System.Security.Cryptography;

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

/*

int age = 16;
bool isWithParents = false;

if (age >= 18 && isWithParents)
{
    Console.WriteLine("Go to a school party with your parents.");
} else if (age <= 18)
{
    Console.WriteLine("Party by yourself.");
} else if (age < 6)
{
    Console.WriteLine("Be a kid!");
}

*/