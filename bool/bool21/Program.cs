// See https://aka.ms/new-console-template for more information
Console.WriteLine("21");
int n = int.Parse(Console.ReadLine());
int a = n / 100;       
int b = (n / 10) % 10;
int c = n % 10;         
bool res = a < b && b < c;
Console.WriteLine(res);
