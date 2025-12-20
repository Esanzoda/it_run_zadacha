// See https://aka.ms/new-console-template for more information
Console.WriteLine("30");
Console.Write("enter from 1 do 999: ");
int num = int.Parse(Console.ReadLine());
string a = (num % 2 == 0) ? "chotnoe" : "nechotnoe";
string b;

if (num >= 1 && num <= 9)
    b = "one";
else if (num >= 10 && num <= 99)
    b = "two";
else 
    b = "three";

Console.WriteLine($"{a} {b}");