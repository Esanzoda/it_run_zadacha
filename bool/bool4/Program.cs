// See https://aka.ms/new-console-template for more information
Console.WriteLine("4");
Console.Write(" A= ");
int A = int.Parse(Console.ReadLine());
Console.Write(" B= ");
int B = int.Parse(Console.ReadLine());
bool res = (A > 2) && (B <= 3);
Console.WriteLine("REs=? " + res);
Console.ReadKey();
