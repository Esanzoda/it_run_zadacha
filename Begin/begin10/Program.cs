
// See https://aka.ms/new-console-template for more information
Console.WriteLine("10");
Console.Write("Enter a= ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enterb ");
double b = double.Parse(Console.ReadLine());
double a2 = a * a;   
double b2 = b * b;  
Console.WriteLine("sum = " + (a2 + b2));
Console.WriteLine("raz= " + (a2 - b2));
Console.WriteLine("proiz = " + (a2 * b2));
Console.WriteLine("taqsim = " + (a2 / b2));
Console.ReadKey();
