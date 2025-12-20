// See https://aka.ms/new-console-template for more information
Console.WriteLine("16");
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());
bool c= (n >= 10 && n <= 99) && (n % 2 == 0);
Console.WriteLine(c ? "истинно." : "ложно.");