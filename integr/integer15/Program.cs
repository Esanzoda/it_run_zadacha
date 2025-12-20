// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Напишите трёх значное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100;
int c =( (a / 10)%10)*10;
int d = (a % 10)*100;
Console.WriteLine($"{a} ->\n{d+c+b}");
