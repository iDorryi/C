// int[] Array(int size)
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < array.Length; i++) // array.Length = size
//     {
//         array[i] = new Random().Next(100, 1000); // => от 100 до 1000
//     }
//     return array;
// }
// int[] resultArray = Array(8);
// // Конвертируем массив в строчку
// Console.WriteLine($"Result array: [ {String.Join("; ", resultArray)} ]");

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console. WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве:");
int size = 10; 
int[] array = new int[size];
int count = 0; // количество четных символов
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 999); 
Console.Write(array[i] + "\t");
if(array[i] % 2 == 0) count++;
}
Console.WriteLine("\n" + $"Четные: {count}");




