// See https://aka.ms/new-console-template for more information
Console.WriteLine("20");
Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 100;         
int a2 = (a / 10) % 10;       
int a3 = a % 10;             
bool al = (a1 != a2) && (a1 != a3) && (a2 != a3);

Console.WriteLine(al ? "True" : "fals");
Console.ReadKey();