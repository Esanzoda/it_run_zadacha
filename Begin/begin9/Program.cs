// See https://aka.ms/new-console-template for more information
Console.WriteLine("9");
Console.Write("Enter a: ");
double a = double.Parse(Console.ReadLine()); 
Console.Write("Enter b: ");
double b = double.Parse(Console.ReadLine()); 
double Sgeom = Math.Sqrt(a * b); 
Console.WriteLine("Srednoe geoemtricheskoe = " + Sgeom);
Console.ReadKey();