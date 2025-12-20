// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
Console.Write("Enter number ");
int num = int.Parse(Console.ReadLine());
string a;
if (num == 0)
    a = "number is 0";
else
{
    string b = (num % 2 == 0) ? "even" : "odd";
    string c = (num > 0) ? "positiv" : "negetiv";
    a = $"{c} {b} ";
}

Console.WriteLine("number id "+a);
Console.ReadKey();