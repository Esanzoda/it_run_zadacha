// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = 0;
if (a > 0) d++;
else if (b > 0) d++;
else if (c > 0) d++;
bool res = d == 2;
Console.WriteLine(res);
