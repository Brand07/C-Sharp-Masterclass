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
	score++;
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
	score++;
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
	score++;
}
else
{
	Console.WriteLine($"Wrong, the correct answer is {answerThree}.");
}

switch (score)
{
	case 1:
		score = 1;
		Console.WriteLine("You got 1 out of 3 answers correct.");
		break;
	case 2:
		score = 2;
		Console.WriteLine("You got 2 out of 3 answers correct.");
		break;
	case 3:
		score = 3;
		Console.WriteLine("You got 3 out of 3 correct!");
		break;
	default:
		Console.WriteLine("You got 0 out of 3 right.");
		break;
}
Console.WriteLine($"Your score is {score}.");
