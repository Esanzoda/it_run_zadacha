// See https://aka.ms/new-console-template for more information
Console.WriteLine("17");
Console.Write("A= ");
double A = double.Parse(Console.ReadLine());

Console.Write("N= ");
int N = int.Parse(Console.ReadLine());

double sum = 1; 
double s = A;

for (int i = 1; i <= N; i++)
{
    sum += s;
    s*= A; 
}

Console.WriteLine("summa " + sum);
Console.ReadKey();