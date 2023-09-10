<Query Kind="Program" />

void Main()
{
	var rand = new Random();
	var randomValues = Enumerable.Range(1, 10)
		.Select(_ => rand.Next(10)-5);
	
	var csvString = new Func<IEnumerable<int>, string>(values => 
	{
		return string.Join(",", values.Select(v => v.ToString()).ToArray());
	});
	
	Console.WriteLine(csvString(randomValues));
	Console.WriteLine(csvString(randomValues.OrderBy(x => x)));
	Console.WriteLine(csvString(randomValues.OrderByDescending(x => x)));
	
	var people = new List<Person>
	{
		new Person {Name = "Adam", Age = 36},
		new Person {Name = "Boris", Age = 30},
		new Person {Name = "Claire", Age = 16},
		new Person {Name = "Jack", Age = 23},
		new Person {Name = "Adam", Age = 12}
	};
	
	//Console.WriteLine(people.OrderBy(p => p.Age));
	//IOrderedEnumerable<Person> sortedPeople = people.OrderBy(p => p.Age);
	//Console.WriteLine(people);
	Console.WriteLine(people.OrderBy(p => p.Name)
							.ThenByDescending(p => p.Age));

	string s = "This string is reversed";
	
	Console.WriteLine(new string(s.Reverse().ToArray()));
}

// Define other methods and classes here

class Person
{
	public string Name;
	public int Age;
}