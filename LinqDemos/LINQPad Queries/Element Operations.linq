<Query Kind="Statements" />

var numbers = new List<int> {1, 2, 3};

Console.WriteLine(numbers.First());
Console.WriteLine(numbers.First(x => x > 2));
Console.WriteLine(numbers.FirstOrDefault(x => x > 10));

Console.WriteLine(numbers.Last());
Console.WriteLine(numbers.Last(x => x < 3));

Console.WriteLine(new int[] {}.SingleOrDefault());

Console.WriteLine("Item at position 1: " + numbers.ElementAt(1));
Console.WriteLine("Item at position 4: " + numbers.ElementAtOrDefault(4));
