// See https://aka.ms/new-console-template for more information
Console.WriteLine("18");
Console.Write("Enter A= ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter A=: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Enter A= ");
int C = int.Parse(Console.ReadLine());
int differentnumber;

if (A == B && A != C)
    differentnumber = 3; 
else if (A == C && A != B)
    differentnumber = 2; 
else
    differentnumber = 1; 

Console.WriteLine("diferentnumber is " + differentnumber+"yumash");
