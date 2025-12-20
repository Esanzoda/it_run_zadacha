// See https://aka.ms/new-console-template for more information
Console.WriteLine("33"); 
Console.Write("must n>1 n= ");
int N = int.Parse(Console.ReadLine());

long F1 = 0, F2 = 1;
Console.Write(F1 + " " + F2 + " ");

for (int i = 3; i <= N; i++)
{
    long F = F1 + F2;
    Console.Write(F + " ");
    F1 = F2;
    F2 = F;
}
Console.ReadKey();