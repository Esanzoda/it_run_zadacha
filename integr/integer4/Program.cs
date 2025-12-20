// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("a=");
float a = Convert.ToInt64(Console.ReadLine());
Console.Write("b=");
float b = Convert.ToInt64(Console.ReadLine());
float c = a % b;
Console.WriteLine($"{c}m otrezok ostalos ot{a} burrem agar  {b}m ri");
