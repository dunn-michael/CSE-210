// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("My Name is Michael Dunn");

Console.WriteLine("What is your name? : ");
string? name = Console.ReadLine();
Console.Write("What is your name? : ");
string? name2 = Console.ReadLine();

Console.WriteLine(name);

int x = 3;
int y = 5;

if (x > y){
    Console.WriteLine("X is greater than Y");
}

if (y > x){
    Console.WriteLine("Y is greater than X");
}

string school = "Brigham Young University - Idaho";

Console.WriteLine($"Are you going to {school}? : ");
string? question = Console.ReadLine();
if (question == "yes"){
    Console.WriteLine("Success!");
}
while (question == "yes"){
    Console.WriteLine("YOU ARE A GENIUS!");
}