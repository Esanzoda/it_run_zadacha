// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");
double pi = 3.14;

//1
/*int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("P="+4*a+"  4*a");*/
//2
/*
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("S=(a*a)="+a*a);*/
//3
/*
Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
int S = a * b;
Console.WriteLine("S=(a*b)="+S);
int P = 2 * (a + b);
Console.WriteLine("P=2*(a+b)="+P);
*/
//4
/*
Console.Write("d=");
double d = double.Parse(Console.ReadLine());
double L = pi * d;
Console.WriteLine("L=(pi*d)"+L);
*/
//8
/*
float a, b,c;
Console.Write("write a=");
a = float.Parse(Console.ReadLine());
Console.Write("write b=");
b = float.Parse(Console.ReadLine());
c = (a + b) / 2;
Console.WriteLine("Средние арифметические a и b="+c);
*/
//9
/*
float a, b;
Console.Write("write a=");
a = float.Parse(Console.ReadLine());
Console.Write("write b=");
b = float.Parse(Console.ReadLine());
double c = Math.Sqrt(a+b);
Console.WriteLine("Средние геометрические a и b=" + c);
*/
//10
/*

float a, b,ka,kb,sj,sz,st,stq, sk;
Console.Write("a=");
a = Convert.ToInt64(Console.ReadLine());
//a = float.Parse(Console.ReadLine());
Console.Write("b=");

b= float.Parse(Console.ReadLine());
ka = a * a;
kb = b * b;
sj = ka + kb;
sz = ka * kb;
st = ka - kb;
stq = ka / kb;
sk=Math.Abs(ka)+Math.Abs(kb);
//16
int x1=2, x2=5;
int x3 = x2 - x1;
Console.WriteLine("x3="+x3);

Console.WriteLine("sj= "+sj+" st= "+st+" sz= "+sz+" stq= "+stq+" sk=");
*/
//12
/*
double a, b, c, P=0;
Console.Write("a=");
a=Convert.ToDouble(Console.ReadLine());
Console.Write("b=");
b=double.Parse(Console.ReadLine());
double A = Math.Pow(a, 2);
double B = Math.Pow(b, 2);
c = Math.Sqrt(A + B);

if (c > 18)
{
    P = a + b + c;

    Console.WriteLine("its correct");
}
else
{
    Console.WriteLine("Not found");
}

    Console.WriteLine("c=" + c + " P=" + P);
*/

//13
/*
double r1, r2, s1, s2, s3;
Console.WriteLine("Write R1 big then R2");
Console.Write("R1=");
r1=Convert.ToDouble(Console.ReadLine());
Console.Write("R2=");
r2 =Convert.ToDouble(Console.ReadLine());
if (r1 > r2)
{
s1=pi*Math.Pow(r1, 2);
 s2=pi*Math.Pow(r2, 2);
    s3 = s1 - s2;
    Console.WriteLine("s1=" + s1 + " s2=" + s2 + " s3=" + s3);
}
else
{
    Console.WriteLine("Write R1 big then R2");
}
*/


/*for(int i = 1; i < 4; i++)
{
    Console.WriteLine(i);
}*/
/*
for (int i = 1, j = 1; i < 10 && j <= 7; i++, j++)
    Console.WriteLine($"{i * j}");*/
/*
int i = 6;
do
{
    Console.WriteLine(i);
    i-=5;
}
while (i > 0);
*/
/*
foreach (char c in "Tom")
{
    Console.WriteLine(c);
}*/
/*
foreach (var c in "Tom")
{
    Console.WriteLine(c);
}*/
/*
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        ///  break;
        continue;
    Console.WriteLine(i);
}*/



for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
   Console.WriteLine("Vali");
}


