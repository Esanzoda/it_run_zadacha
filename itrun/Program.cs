// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a = 85;
if (a <= 90)
{
    Console.WriteLine("a");

}
else if (a <= 80)
{
    Console.WriteLine("b");
}
else if (a <= 70)
{
    Console.WriteLine("c");
}
else if (a <= 60)
{
    Console.WriteLine("c");
}
else
{
    Console.WriteLine("F");
}
*/
/*
int a = 10;
int b = 11;
int max = (a > b) ? a : b;
Console.WriteLine(max);*/
/*
int a = 3;
string n;
switch (a)
{
    case 1:
        n = "monday";
        break;
    
        n = "tuthday";
        break;
    case 3:
        n = "friday";
        break;
    case 4:
        n = "seturday";
        break;
    default:
        n = "nodurust";
        break;
}
Console.WriteLine(n);
*//*
int[] s = {1,2,3,4,5,6,8 };
foreach (int i in s)
{
    Console.WriteLine(i);
}*/
/*
string pas = "";
while (pas != "sec")
{
    Console.WriteLine("enter pas");
    pas = Console.ReadLine();
}*//*
for (int i=1; i < 10; i++)
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}*/
/*15% ёфтан
    среда значение мвссив */


/*
Console.Write("a=");
int a= int.Parse(Console.ReadLine());
Console.Write("b=");
int b= int.Parse(Console.ReadLine());
Console.Write("1= +");
Console.Write("2= -");
Console.Write("3= *");
Console.Write("4= /");

double c= double.Parse(Console.ReadLine());
/*
Console.WriteLine("A MOYA 15%="+(a * 15) / 100);
*/
/*
if (a > 0)
{
    Console.WriteLine("posiyive");
}
else if (a == 0)
{
    Console.WriteLine("zero");
}
else
{
    Console.WriteLine("negetiv");

}*/
/*
switch (c)
{
    case 1:
        Console.Write($"c={a + b}");
        break;
    case 2:
        Console.Write($"c={a -b}");
        break;
    case 3:
        Console.Write($"c={a * b}");
        break;
    case 4:
        Console.Write($"c={a / b}");
        break;
}
*/

//5
/*
Console.WriteLine("kakow kara");
int a= int.Parse(Console.ReadLine());
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{a*i}");
}
*/
//6
/*
int i = 1;
int sum = 0;
while (i <= 100)
{
    
   
    sum += i;

    i++;
}
Console.WriteLine($"{sum}");
*/

//7

string[] desert = { "kis", "fit" };
string[] sup = { "kharcho", "KHomshurbo" };
Console.WriteLine("intikhob kuned 1 or 2");
int n=int.Parse(Console.ReadLine());
if (n == 1)
{
    foreach (string g in sup)
    {
        Console.WriteLine(g);
    }
}
else
{
    Console.WriteLine("khushomaded");
}
Console.WriteLine(" desert intikhom mekuned");
string s =Console.ReadLine();

if (n == 2)
{
    foreach (string f in desert)
    {
        Console.WriteLine(f);
    }
}
else
{
    Console.WriteLine("khushomaded");
}




