// See https://aka.ms/new-console-template for more information
Console.WriteLine("32");
Console.Write("Enter TC ");
double TC = double.Parse(Console.ReadLine());
double TF = TC * 9 / 5 + 32;
Console.WriteLine("TF = " + TF);
Console.ReadKey();