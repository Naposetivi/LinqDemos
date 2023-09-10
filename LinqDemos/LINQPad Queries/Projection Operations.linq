<Query Kind="Statements" />

var numbers = Enumerable.Range(1, 4);
var squares = numbers.Select(x => x*x);
//Console.WriteLine(squares);

string sentence = "This is a nice sentence";
var wordLengths = sentence.Split().Select(w => w.Length);
//Console.WriteLine(wordLengths);

var wordWithLength = sentence.Split()
.Select(w => new{Word = w, Size = w.Length});
//Console.WriteLine(wordWithLength);

Random rand = new Random();
var randomNumbers = Enumerable.Range(1, 10).Select(_ => rand.Next(10));
//Console.WriteLine(randomNumbers);

var sequences = new[] {"red,blue,green", "orange", "white,pink"};
var allWords = sequences.SelectMany(s => s.Split(','));
//Console.WriteLine(allWords);

string[] objects = {"house", "car", "bicycle"};
string[] colors = {"green", "red", "gray"};
var pairs = colors.SelectMany(_ => objects, (c, o) => new {Color = c, Object = o});
Console.WriteLine(pairs);