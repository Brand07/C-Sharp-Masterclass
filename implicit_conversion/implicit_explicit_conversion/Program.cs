//implicit conversion

int myInt = 13;
//Double holds more than an int
double myDouble = myInt;
//Long can hold more data than an a double
long myLong = myInt;

long myLong2 = 1234934535534865;

/*
 * You can go up in size but not down
 */
 
 //Explicit conversion
 int myInt2 = (int)myLong2;
//Works, but an int can't display all the data
 Console.WriteLine(myInt2);
 
float myFloat = 123.123f;
myDouble2 = 13.23434343234;

myFloat = (float)myDouble2;
Console.WriteLine(myFloat);