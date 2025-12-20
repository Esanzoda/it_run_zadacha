// See https://aka.ms/new-console-template for more information
Console.WriteLine("22");
Console.Write(" Enter A ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter B= ");
int B = int.Parse(Console.ReadLine());
int C = A; A = B; B = C;
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);
Console.ReadKey();