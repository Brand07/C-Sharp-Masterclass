namespace OldStyle;

class Program
{
	// Global variable | field or instance variable
	int myResult;

	static void Main(string[] args)
	{
		Program program = new Program();

		Console.WriteLine("Enter a number, and I'll add 10 to it!");
		int num1 = int.Parse(Console.ReadLine());

		program.myResult = AddTwoValues(num1, 10);
		Console.WriteLine($"The result is {program.myResult}");
	}

	// static allows a method to be used outside of the main method
	static int AddTwoValues(int value1, int value2)
	{
		int result = value1 + value2;
		return result;
	}

	static int SubtractTwoValues(int value1, int value2)
	{
		int result = value1 - value2;
		return result;
	}
}
