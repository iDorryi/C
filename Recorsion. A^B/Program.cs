Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int degree = Convert.ToInt32(Console.ReadLine());
int PowNumber (int number, int power)
{
    if(power == 0) return 1;
    if (power == 1 ) return number;
    return (number * PowNumber(number, power - 1 ));
}
System.Console.WriteLine(PowNumber(number, degree));