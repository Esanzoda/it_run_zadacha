// See https://aka.ms/new-console-template for more information
Console.WriteLine("28");
Console.Write("Endter A= ");
double A = double.Parse(Console.ReadLine());
double A2 = A * A;          
double A3 = A2 * A;         
double A5 = A2 * A3;       
double A10 = A5 * A5;       
double A15 = A10 * A5;
Console.WriteLine("A^2 = " + A2);
Console.WriteLine("A^3 = " + A3);
Console.WriteLine("A^5 = " + A5);
Console.WriteLine("A^10 = " + A10);
Console.WriteLine("A^15 = " + A15);
Console.ReadKey();