//Equality operators

int num1 = 0;
int num2 = 0;

//Checks for equality
bool isEqual = num1 == num2; // true
//Checks for inequality
bool isNotEqual = num1 != num2; // false


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