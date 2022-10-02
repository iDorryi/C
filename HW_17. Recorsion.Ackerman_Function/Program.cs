Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n: ");

int Input(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int m = Input("Введите число m: "); 
int n = Input("Введите число n: ");

    int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return AckermanFunction(m - 1, 1);
        }
        else
        {
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        }
    }
}
Console.WriteLine($"Функция Аккермана : {AckermanFunction( m, n)}");

