Console.WriteLine(" Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива:");
int size = 4;
double[] array = new double [size];

for (int i = 0; i < size; i++)
{
 array[i] = new Random().NextDouble() * 100;
 Console.Write(array[i] + "\t" );
}
double max = array[0];
double min = array[0];
for (int i = 0; i < size; i++)
{
  if (array[i] < min) min = array[i]; 
  if (array[i] > max) max = array[i]; 
}
double diff = max - min;
Console.WriteLine("\n" + $"Максимальное значение = {max}" + "\n" + $"Минимальное значение = {min}" + "\n" + $"Разница между максимальным и минимальным числом: {Math.Round((diff),2)}");

