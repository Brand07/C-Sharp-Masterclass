using System.Security.Cryptography;

namespace WeatherStationSimulation;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the number of days to simulate");
		int days = int.Parse(Console.ReadLine());

		int[] temperature = new int[days];
		string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
		string[] weatherConditions = new string[days];

		Random random = new Random();

		for (int i = 0; i < days; i++)
		{
			temperature[i] = random.Next(-10, 40);
			weatherConditions[i] = conditions[random.Next(conditions.Length)];
		}

		static double CalculateAverage(int[] temperature)
		{
			int sum = 0;
			for (int i = 0; i < temperature.Length; i++)
			{
				sum += temperature[i];
			}
			double average = sum / temperature.Length;
			return temperature[0];
		}

		//double averageTemp = CalculateAverage(temperature);
		Console.WriteLine($"Average temperature is: {CalculateAverage(temperature)}");
	}
}
