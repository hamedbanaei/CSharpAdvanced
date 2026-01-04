// ********** ********** ********** ********** **********
// Learn01: Without Event
// ********** ********** ********** ********** **********

using Events.Learn01;

Person P1 = new Person
{
	Age = 43,
	FullName = "Hamed Banaei",
};

P1.Age = 25;
P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn01: Without Event
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn02: Event with Customised Delegate
// ********** ********** ********** ********** **********

//using Events.Learn02;

//void P1_AgeChanged(object sender)
//{
//	System.Console.WriteLine($"Age changed!");
//}

//Person P1 = new Person
//{
//	Age = 43,
//	FullName = "Hamed Banaei",
//};

//P1.AgeChanged += P1_AgeChanged;

//P1.Age = 25;
//P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn02: Event with Customised Delegate
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn03: What if we need Customized Message?!
// ********** ********** ********** ********** **********

//using Events.Learn03;

//void P1_AgeChanged(object sender)
//{
//	//Person oPerson = (Person)sender; // May throw error!
//	//System.Console.WriteLine($"{oPerson.FullName}'s Age changed!");

//	if (sender is Person oPerson)
//	{
//		System.Console.WriteLine($"Age of '{oPerson.FullName}' changed!");
//	}
//}

//Person P1 = new Person
//{
//	Age = 43,
//	FullName = "Hamed Banaei",
//};

//P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;

//P1.Age = 25;
//P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn03: What if we need Customized Message?!
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn04: How to get rid of object?!
// ********** ********** ********** ********** **********

//using Events.Learn04;

//void P1_AgeChanged(Person sender)
//{
//	System.Console.WriteLine($"Age of '{sender.FullName}' changed!");
//}

//Person P1 = new Person
//{
//	Age = 43,
//	FullName = "Hamed Banaei",
//};

//P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;

//P1.Age = 25;
//P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn04: How to get rid of object?!
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn05: Microsoft default Delegate
// ********** ********** ********** ********** **********

//using Events.Learn05;

//void P1_AgeChanged(object sender, System.EventArgs e)
//{
//	System.Console.WriteLine($"Age changed!");
//}

//Person P1 = new Person
//{
//	Age = 43,
//	FullName = "Hamed Banaei",
//};

//P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;
////P1.AgeChanged += P1_AgeChanged;

//P1.Age = 25;
//P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn05: Microsoft default Delegate
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn06: Let programmer control the change flow
// ********** ********** ********** ********** **********

//using Events.Learn06;

//void P1_BeforeAgeChanged(object sender, AgeChangeEventArgs e)
//{
//	System.Console.WriteLine($"Age change requested from '{e.OldAgeValue}' to '{e.NewAgeValue}'");

//	e.Cancel = e.NewAgeValue switch
//	{
//		< 0 or > 200 => true,
//		_ => false,
//	};
//}

//void P1_AfterAgeChanged(object sender, AgeChangeEventArgs e)
//{
//	System.Console.WriteLine($"Age changed from '{e.OldAgeValue}' to '{e.NewAgeValue}'");
//}

//Person P1 = new Person
//{
//	Age = 43,
//	FullName = "Hamed Banaei",
//};

//P1.BeforeAgeChanged += P1_BeforeAgeChanged;
//P1.AfterAgeChanged += P1_AfterAgeChanged;

//P1.ShowInfo();
//System.Console.WriteLine(System.Environment.NewLine);

//P1.Age = 25;
//P1.ShowInfo();
//System.Console.WriteLine(System.Environment.NewLine);

//P1.Age = -1;
//P1.ShowInfo();
//System.Console.WriteLine(System.Environment.NewLine);

// ********** ********** ********** ********** **********
// / Learn06: Let programmer control the change flow
// ********** ********** ********** ********** **********