namespace Events.Learn06;

public class AgeChangeEventArgs : System.EventArgs
{
	public bool Cancel { get; set; }

	public int OldAgeValue { get; set; }
	public int NewAgeValue { get; set; }

	public AgeChangeEventArgs(int oldAgeValue, int newAgeValue)
	{
		Cancel = false;
		OldAgeValue = oldAgeValue;
		NewAgeValue = newAgeValue;
	}
}

public delegate void AgeChangedHandler(object sender, AgeChangeEventArgs e);

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
			AgeChangeEventArgs e
				= new AgeChangeEventArgs(_age, value);

			OnBeforeAgeChanged(e);
			if (e.Cancel == false)
			{
				_age = value;
				OnAfterAgeChanged(e);
			}
		}
	}

	public string FullName { get; set; }

	public event AgeChangedHandler BeforeAgeChanged; // AgeChanging would be better!
	protected virtual void OnBeforeAgeChanged(AgeChangeEventArgs e)
	{
		if (BeforeAgeChanged != null)
		{
			BeforeAgeChanged(this, e);
		}
	}

	public event AgeChangedHandler AfterAgeChanged; // AgeChanged would be better!
	protected virtual void OnAfterAgeChanged(AgeChangeEventArgs e)
	{
		if (AfterAgeChanged != null)
		{
			AfterAgeChanged(this, e);
		}
	}

	public void ShowInfo()
	{
		System.Console.WriteLine("FullName: {0}, Age: {1}", FullName, Age);
	}
}
