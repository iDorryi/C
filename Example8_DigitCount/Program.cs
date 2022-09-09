Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetCountNumbers(number));
int GetCountNumbers(int num)
{   // Переменная может называться как угодно
    int count = 0; // Изначально нет числа и 0 цифр
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;  // Количество цифр в числе
}