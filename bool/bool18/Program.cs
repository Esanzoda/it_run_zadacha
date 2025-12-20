// See https://aka.ms/new-console-template for more information
Console.WriteLine("18!");
Console.Write("first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("third number: ");
int c = int.Parse(Console.ReadLine());
bool d = (a == b) || (a == c) || (b == c);
Console.WriteLine(d ? "true" : "fols");
Console.ReadKey();
