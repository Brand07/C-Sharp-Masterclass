namespace ClassesApp;

/*This is internal and can only be accessed within the same assembly*/

public class Car
{
	//Member variable
	//Private hides the variable from other classes
	private string _brand = "";
	private string _model = "";
	
	//Constructor
	public Car(string brand, string model)
	{
		_brand = brand;
		_model = model;
		Console.WriteLine($"A car with the brand of {_brand} and the model {_model} has been created.");
	}
}
