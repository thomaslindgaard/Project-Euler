// See https://aka.ms/new-console-template for more information

Console.WriteLine("Find sum of all even Fibonacci numbers below 4 million");
const int limit = 4000000;
int a = 1, b = 2;
var sum = 0;

while (b < limit)
{
    if (b % 2 == 0)
        sum += b;
    var temp = a + b;
    a = b;
    b = temp;
}

Console.WriteLine($"Sum of even Fibonacci numbers below {limit:N0}: {sum:N0}");