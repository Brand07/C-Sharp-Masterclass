Console.WriteLine("Give me a number");
string inputString = Console.ReadLine(); 
int num1;

int.TryParse(inputString, out num1);
num1++;
Console.WriteLine($"User entered number + 1 {num1}");