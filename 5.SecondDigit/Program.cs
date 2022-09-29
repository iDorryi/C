Console.WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number > 100 && Number < 999)
{
  int FirstDigit = Number % 100;
  int SecondDigit = FirstDigit / 10;
  Console.WriteLine($"Вторая цифра числа {Number} - {SecondDigit}");
};

