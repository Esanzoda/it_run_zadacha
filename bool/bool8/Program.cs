// See https://aka.ms/new-console-template for more information
Console.WriteLine("8");
Console.Write(" A= ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Console.Write(" B= ");
bool a = A % 2 != 0;
bool b = B % 2 != 0;
bool c = a && b; 
Console.WriteLine("Res= " + c);
Console.ReadKey();