namespace Events.Learn05;

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

	public event System.EventHandler AgeChanged;
	protected virtual void OnAgeChanged()
	{
		if (AgeChanged != null)
		{
			//AgeChanged(this, null); // Better not to send null!
			AgeChanged(this, new System.EventArgs());
		}
	}

	public void ShowInfo()
	{
		System.Console.WriteLine("FullName: {0}, Age: {1}", FullName, Age);
	}
}
