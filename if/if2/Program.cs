// See https://aka.ms/new-console-template for more information
Console.WriteLine("2");
Console.Write("Enter number ");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    num += 1;
}
else
{
    num -= 2;
}

Console.WriteLine("res " + num);
Console.ReadKey();