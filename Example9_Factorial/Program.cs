Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine()); // Глобальная , то есть, доступна везде
Console.WriteLine(GetMultiply(N));
Console.WriteLine(GetMultiply(5));
Console.WriteLine(GetMultiply(6));
Console.WriteLine(GetMultiply(7));
Console.WriteLine(GetMultiply(8));

// PascalCase - обе буквы заглавные: PrintNumbers
int GetMultiply (int N) // Вторая переменная, она локальная
// Она живет только внутри метода, только внутри {}
{
    int result = 1; // Число * 0 = 0
    for (int i = 2; i <= N; i++)
    {
        result *= i; // result = result * i
    }
    return result; 
}