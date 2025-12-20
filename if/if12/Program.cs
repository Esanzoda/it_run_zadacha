// See https://aka.ms/new-console-template for more information
Console.WriteLine("12");
Console.Write("Enter A= ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter A=: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Enter A= ");
int C = int.Parse(Console.ReadLine());
int min = A;
if (B < min) min = B;
if (C < min) min = C;

Console.WriteLine("min number= " + min);
Console.ReadKey();