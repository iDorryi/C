Console.Write("Введите координату х1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между этими двумя точкм - {d}");


