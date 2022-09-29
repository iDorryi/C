Console.WriteLine("Введите 5-и значное число");
string Number = Console.ReadLine();
if (Number[0] == Number[4] && Number[1] == Number[3])
{
Console.WriteLine($"Число {Number} - Палиндром");
}
else if (Number[0] != Number[4] && Number[1] != Number[3])
{
Console.WriteLine($"Что за бред! Число {Number} - не палиндром");
}
