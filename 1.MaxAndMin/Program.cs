int a = new Random().Next(-10,10);
Console.WriteLine(a);
int b = new Random().Next(-10,10);
Console.WriteLine(b);

int max = a;
int min = b; 

if (a > b)
{
 max = a; min = b; 
} 
else 
{
 max = b; min = a;
}

Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= "); 
Console.WriteLine(min);

