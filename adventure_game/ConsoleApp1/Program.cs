/*
Text Adventure Game
Author: Brandon Yates
Date: September 16th, 2024
*/

Console.WriteLine("Welcome to the adventure game!");
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character's class (Warrior, Wizard, Archer");
string characterType = Console.ReadLine();

Console.WriteLine($"$You, {playerName} the {characterType} find yourself at the edge" +
                  $"of a dark forrest.. ");
Console.WriteLine("Do you enter the forrest or camp outside? (Enter/Camp)");
string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
	Console.WriteLine("You bravely enter the forrest..");
}
else
{
	Console.WriteLine("You devide to wait until daylight.");
}                 

bool gameContinues = true;

while (gameContinues)
{
	Console.WriteLine("You've come to a fork in the road. Go left or right?");
	string direction = Console.ReadLine();
	if (direction.ToLower() == "left")
	{
		Console.WriteLine("You find a treasure chest!");
		gameContinues = false;
	}
	else
	{
		Console.WriteLine("You encounter a wild beast!");
		Console.WriteLine("Fight or flee? (fight/flee)");
		string fightChoice = Console.ReadLine();
		if (fightChoice.ToLower() == "fight")
		{
			Random random = new Random();
			int luck = random.Next(1, 11);
			if (luck > 5)
			{
				Console.WriteLine("You beat the wild beast!");
				if (luck > 8)
				{
					Console.WriteLine("The wild beast dropped a treasure!");
				}
				else
				{
					Console.WriteLine("The beast attaked you and knocked you out.");
					gameContinues = false;
				}
			}
		}
	}
	
}