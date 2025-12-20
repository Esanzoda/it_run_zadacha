// See https://aka.ms/new-console-template for more information
Console.WriteLine("23");
Console.WriteLine("Enter A=");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B=");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Enter C=");
int C = int.Parse(Console.ReadLine());
int D = A;
A = C;
C = B;
B = D;
Console.WriteLine("A=" + A + "B=" + B + "C=" + C);
Console.ReadKey();
