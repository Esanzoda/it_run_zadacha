// See https://aka.ms/new-console-template for more information
Console.WriteLine("23");
int n = int.Parse(Console.ReadLine());
int a = n / 1000;            
int b = (n / 100) % 10;     
int c = (n / 10) % 10;     
int d = n % 10;             
bool res = (a == d) && (b == c);
Console.WriteLine(res);