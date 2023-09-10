<Query Kind="Statements" />

var list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);
//Console.WriteLine(list.Select(i => (int)i).Sum());
//Console.WriteLine(list.Cast<int>().Sum());

var numbers = Enumerable.Range(1, 10);
var arr = numbers.ToArray(); // ToList()
var dict = numbers.ToDictionary(i => (double)i/10, i => i%2 == 0);
Console.WriteLine(dict);

var arr2 = new[]{1, 2, 3};
IEnumerable<int> arre = arr2.AsEnumerable();