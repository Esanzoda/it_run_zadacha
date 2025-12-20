// See https://aka.ms/new-console-template for more information
Console.WriteLine("A<C<B");
Console.Write("A= ");
double A = double.Parse(Console.ReadLine());
Console.Write("B=");
double B = double.Parse(Console.ReadLine());
Console.Write("С= ");
double C = double.Parse(Console.ReadLine());
double AC = Math.Abs(A - C);
double BC = Math.Abs(B - C);
double res = AC * BC;
Console.WriteLine("res AC and BC modul = " + res);
Console.ReadKey();