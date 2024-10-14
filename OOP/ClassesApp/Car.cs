namespace ClassesApp;

/*This is internal and can only be accessed within the same assembly*/

public class Car
{
	//Member variable
	//Private hides the variable from other classes
	private string _brand = "";
	private string _model = "";
	
	//Property
	public string Model { get => _model; set => _model = value; }
	public string Brand { get => _brand; set => _brand = value; }
	
	//Constructor
	public Car(string brand, string model)
	{
		Brand = brand;
		Model = model;
		Console.WriteLine($"A car with the brand of {_brand} and the model {_model} has been created.");
	}
}
