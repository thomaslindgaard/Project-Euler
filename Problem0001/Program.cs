// See https://aka.ms/new-console-template for more information

Console.WriteLine("Find sum of multiples of 3 and 5 below 1.000");

var multiples = Enumerable.Range(1, 999).Where(n => n % 3 == 0 || n % 5 == 0);
var sum = multiples.Sum();
Console.WriteLine($"Sum: {sum}");