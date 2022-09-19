Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь:");

Console.WriteLine("Введите количество чисел массива" + "\t");
int M = Convert.ToInt32(Console.ReadLine());
int size = M; 
int[] array = new int[M];
int count = 0; 
for (int i = 0; i < M; i++)
{
 Console.WriteLine($"Введите элемента массива с индексом {i}: \t");
 array[i] = Convert.ToInt32(Console.ReadLine());
  if( array[i] >= 0 ) count ++;
}
Console.WriteLine("\n" + $"Количество положительных чисел =  {count}");
