// See https://aka.ms/new-console-template for more information
Console.WriteLine("2");
Console.Write("A= ");
int A = int.Parse(Console.ReadLine());

Console.Write(" IF B>A  B= ");
int B = int.Parse(Console.ReadLine());

int c = 0;
for (int i = A; i <= B; i++)
{
    Console.Write(i + " ");
    c++;
}
Console.WriteLine("number=  " + c);
Console.ReadKey();
