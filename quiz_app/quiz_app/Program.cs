string questionOne = "What is the capital of Germany: ";
string answerOne = "Berlin";

string questionTwo = "What is 2+2?";
string answerTwo = "4";

string questionThree = "What color do you get by mixing blue and yellow?";
string answerThree = "Green";

int score = 0;

Console.WriteLine(questionOne);
string userAnswerOne = Console.ReadLine();
if (userAnswerOne == answerOne)
{
	Console.WriteLine("Correct!");
	score = score + 1;
}
else
{
	Console.WriteLine($"Wrong, the correct answer is {answerOne}.");
}

Console.WriteLine(questionTwo);
string userAnswerTwo = Console.ReadLine();
if (userAnswerTwo == answerTwo)
{
	Console.WriteLine("Correct!");
	score = score + 1;
}
else
{
	Console.WriteLine($"Wrong, the correct answer is {answerTwo}.");
}

Console.WriteLine(questionThree);
string userAnswerThree = Console.ReadLine();
if (userAnswerThree == answerThree)
{
	Console.WriteLine("Correct!");
	score = score + 1;
}
else
{
	Console.WriteLine($"Wrong, the correct answer is {answerThree}.");
}

