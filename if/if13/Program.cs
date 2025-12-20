// See https://aka.ms/new-console-template for more information
Console.WriteLine("13");
Console.Write("Enter A= ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter A=: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Enter A= ");
int C = int.Parse(Console.ReadLine());
int smal;

if ((A >= B && A <= C) || (A <= B && A >= C))
    smal= A;
else if ((B >= A && B <= C) || (B <= A && B >= C))
    smal = B;
else
    smal = C;

Console.WriteLine("smal number is " + smal);
Console.ReadKey();
