Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number >= 100 && Number <= 999)
{
  int ThirdDigit = Number % 10;

  Console.WriteLine($"Третья цифра числа {Number} - {ThirdDigit}");
}
else if(Number >= 999 && Number <= 9999)
{
  int SecondDigit = Number % 100;
  int ThirdDigit = SecondDigit / 10;

  Console.WriteLine($"Третья цифра числа {Number} - {ThirdDigit}");
}
else if(Number >= 9999 && Number <= 99999)
{
  int FirstRest = Number % 1000;
  int SecondRest = FirstRest / 10;
  int ThirdDigit = SecondRest / 10;

  Console.WriteLine($"Третья цифра числа {Number} - {ThirdDigit}");
}
else if (Number >= 1 && Number <= 99)
{
  Console.WriteLine($"Третей цифры числа {Number} - нет");
}