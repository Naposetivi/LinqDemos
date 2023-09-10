<Query Kind="Program" />

void Main()
{
	var people = new List<Person>
	{
		new Person {Name = "Adam", Age = 30},
		new Person {Name = "Boris", Age = 30},
		new Person {Name = "Claire", Age = 16},
		new Person {Name = "Jack", Age = 23},
		new Person {Name = "Adam", Age = 16}
	};
	
	IEnumerable<IGrouping<string, Person>> byName = people.GroupBy(p => p.Name);
	//Console.WriteLine(byName);
	//Console.WriteLine(people.GroupBy(p => p.Age < 30));
	
	var byAgeNames = people.GroupBy(p => p.Age, p => p.Name);
	//Console.WriteLine(byAgeNames);
	
	foreach (var item in byAgeNames){
		Console.WriteLine($"These people are {item.Key} years old.");
		foreach(var name in item)
			Console.WriteLine($" - {name}");
	}
}

// Define other methods and classes here
class Person
{
	public string Name;
	public int Age;
}