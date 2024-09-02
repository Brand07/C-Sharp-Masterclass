//Switch statements

int month = 5;
string monthName;

// If / else if / else statements
if (month == 1)
{
	monthName = "January";
}
else if (month == 2)
{
	monthName = "February";
}

// Same solution using Switch statements

switch (month)
{
	case 1:
		monthName = "January";
		break;
	case 2:
		monthName = "February";
		break;
	case 3:
		monthName = "March";
		break;
	default:
		monthName = "Unknown";
		break;
}

Console.WriteLine($"The month name is {monthName}");
