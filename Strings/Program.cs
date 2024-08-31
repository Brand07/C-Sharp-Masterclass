using System;
// Declare a variable of type string
string myName = "Brandon";
// Print the variable to the console
Console.WriteLine(myName);

// Variables can be re-assigned
myName = "Not Brandon";
Console.WriteLine(myName);

// Char datatype - can only contain one character 
// Only characters in UTF-16 format
// Single quotes
//char myFavoriteCharacter = 'a';

//String formatting and interpolation
int num = 10;
double price = 19.95;
string name = "Brandon";
//Interpolation
Console.WriteLine($"The number is {num}");
//Concatination
Console.WriteLine("The number is " + num);

//String formatting
Console.WriteLine("The number is {0} and the price is {1}. Your salesperson is {2}.", num, price, name);

// Special & escape characters
//string s1 = "this is a string with a slash / and a colon: ";
//Console.WriteLine(s1);
// Quoted text in strings has to be escaped with two back slashes.
string s1 = "this is a \"string\" with a slash \\ and a colon: ";
Console.WriteLine(s1);


