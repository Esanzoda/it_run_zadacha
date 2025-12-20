// See https://aka.ms/new-console-template for more information
Console.WriteLine("4");
Console.Write("Enter 1kg chocolate ");
double kg1 = double.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    double sum = i * kg1;
    Console.WriteLine($"{i} кг: {sum}.c");
} Console.ReadKey();
