using System.Collections.Generic;

List<int> numbers = new List<int>();
string str;
int number;
int big = 0;
Console.WriteLine("Enter a list of numbers, type '0' when finished");
do
{
    Console.Write("Enter a number : ");
    str = Console.ReadLine();
    number = int.Parse(str);
    if (number != 0)
    {
    numbers.Add(number);
    }
}while (number != 0);
Console.WriteLine($"The sum is  {numbers.Sum()}");
Console.WriteLine($"The Sorted List : ");
numbers.Sort();
Console.WriteLine(numbers.Max());
foreach (int n in numbers)
{
    if (n > big)
    {
        big = n;
    }
    Console.WriteLine(n);
}
