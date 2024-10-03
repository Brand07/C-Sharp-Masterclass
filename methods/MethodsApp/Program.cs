//Definition of a void method that returns nothing
void MyFirstMethod()
{
	Console.WriteLine("MyFirstMethod was called");
}

Console.WriteLine("This is outside of the method");
//Calling the method
MyFirstMethod();

void WriteSomething()
{
	Console.WriteLine("I'm writing something!");
}
//Method that has the parameter myString of type String
void WriteSomethingSpecific(string myString)
{
	Console.WriteLine($"My string is {myString}");
}

WriteSomethingSpecific("Hello, World!");

//Two params
int AddTwoValues(int value1, int value2)
{
	int result = value1 + value2;
	return result;
}

int SubtractTwoValues(int value1, int value2)
{
	int result = value1 - value2;
	return result;
}

int myReult = AddTwoValues(5, 10);
Console.WriteLine($"My result is {myReult}");


