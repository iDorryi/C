int a = new Random().Next(-10,10);
Console.WriteLine(a);
int b = new Random().Next(-10,10);
Console.WriteLine(b);
int c = new Random().Next(-10,10);
Console.WriteLine(c);

int max = a;
 

if (a > max)
{
 max = a; 
} 
else if (b > max)
{
 max = b; 
}

else if (c > max) 
{
 max = c; 
}

Console.Write("max= ");
Console.WriteLine(max);


