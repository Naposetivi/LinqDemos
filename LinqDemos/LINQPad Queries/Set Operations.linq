<Query Kind="Statements" />

string word1 = "helloooo";
string word2 = "help";

//Console.WriteLine(word1.Distinct());

var lettersInBoth = word1.Intersect(word2);

//Console.WriteLine(lettersInBoth);

//Console.WriteLine(word1.Union(word2));

Console.WriteLine(word1.Except(word2));
Console.WriteLine(word2.Except(word1));