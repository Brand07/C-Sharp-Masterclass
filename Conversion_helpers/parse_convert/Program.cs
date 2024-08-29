//Conversion helpers Parse and Convert

//Parse
string numberString = "123";
int result = int.Parse(numberString);
Console.WriteLine(result);

//Convert
string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine($"myBool is {myBool}");
Console.ReadKey();