namespace Events.Learn01;

public class Person : System.Object
{
	public int Age { get; set; }
	
	public string FullName { get; set; }

	public void ShowInfo()
	{
		System.Console.WriteLine("FullName: {0}, Age: {1}", FullName, Age);
	}
}