// See https://aka.ms/new-console-template for more information
Console.WriteLine("33");
Console.Write("? кг= ");
double X = double.Parse(Console.ReadLine());
Console.Write("рублаш= ");
double A = double.Parse(Console.ReadLine());
Console.Write("? кг ");
double Y = double.Parse(Console.ReadLine());
double kg1 = A / X;
double kgY = kg1 * Y;
Console.WriteLine("1 кг = " + kg1 + " рубл");
Console.WriteLine( Y + " кг = " + kgY + " рубл");
Console.ReadKey();  
