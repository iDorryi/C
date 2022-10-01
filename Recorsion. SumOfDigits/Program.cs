Console.WriteLine("Hello, World!");
int num = Convert.ToInt32(Console.ReadLine());
int SumDigits (int num)
{
    if(num % 10 == 0) return 0;
    return (num % 10 + SumDigits(num/10));
}
System.Console.WriteLine(SumDigits(num));