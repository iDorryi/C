Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях:");
int size = 5; 
int[] array = new int[size];
int odd = 0;
int sum = 0;
for ( int i =0; i< array.Length; i++)
{
array[i] = new Random().Next(0,99);
Console.Write(array[i] + "\t" );
 if (array[i] % 2 != 0) 
 {odd++;
 sum += array[i];
 }
}
Console.WriteLine("\n"+ $"Нечетные: {odd}" +"\n" + $"Сумма: {sum}");
