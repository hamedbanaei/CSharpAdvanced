namespace Events.Learn03;

public delegate void AgeChangedHandler(object sender);

public class Person : System.Object
{
	public Person()
	{
	}

	private int _age;
	public int Age
	{
		get
		{
			return (_age);
		}
		set
		{
			_age = value;
			OnAgeChanged();
		}
	}

	public string FullName { get; set; }

	public event AgeChangedHandler AgeChanged;
	protected virtual void OnAgeChanged()
	{
		if (AgeChanged != null)
		{
			AgeChanged(this);
		}
	}

	public void ShowInfo()
	{
		System.Console.WriteLine("FullName: {0}, Age: {1}", FullName, Age);
	}
}
