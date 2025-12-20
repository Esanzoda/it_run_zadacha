// See https://aka.ms/new-console-template for more information
Console.WriteLine("1!");
Console.Write("K= ");
int K = int.Parse(Console.ReadLine());

Console.Write("N= ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine(K);
}
Console.ReadKey();