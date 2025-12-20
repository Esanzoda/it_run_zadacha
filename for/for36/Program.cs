// See https://aka.ms/new-console-template for more information
Console.WriteLine("36"); 
Console.Write("must n>0: ");
int N = int.Parse(Console.ReadLine());

Console.Write("must k>0 ");
int K = int.Parse(Console.ReadLine());

double sum = 0;
for (int i = 1; i <= N; i++)
{
    double stepen = 1;
    for (int j = 1; j <= K; j++)
    {
        stepen *= i;
    }
    sum += stepen;

    Console.WriteLine("Summ " + sum);
}