// See https://aka.ms/new-console-template for more information
Console.WriteLine("3"); 
Console.Write("Enter number ");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    num += 1;
}
else if (num < 0)
{
    num -= 2;
}
else 
{
    num = 10;
}

Console.WriteLine("Res " + num);
Console.ReadKey();