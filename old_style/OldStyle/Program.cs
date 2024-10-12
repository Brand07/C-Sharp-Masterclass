namespace OldStyle;

class Program
{
	static void Main(string[] args)
	{
		int myResult;

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

		Console.WriteLine("Enter a number, and I'll add 10 to it!");
		int num1 = int.Parse(Console.ReadLine());

		myResult = AddTwoValues(num1, 10);
		Console.WriteLine($"The result is {myResult}");
	}
}
