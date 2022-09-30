Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов:");

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
Console.WriteLine("Это случайно сгенерированный массив:");

int Input(string message)
 {
     Console.Write(message);
     return Convert.ToInt32(Console.ReadLine()!);
 }

 int[,] matrix = new int[rows,columns];
 matrix = FillMatrix(matrix);
 PrintMatrix(matrix);
 Console.WriteLine("Сумма чисел строк двумерного массива: ");
 int[] SumInLinesArray = CountSumInRows(matrix);
 PrintSumInRows(SumInLinesArray);
 Console.WriteLine();
 Console.WriteLine($"Номер строки с наименьшей суммой: {GetMinRowsSum(SumInLinesArray) + 1}");


 int[,] FillMatrix (int[,] matrix)
 {
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
             for (int j = 0; j < matrix.GetLength(1); j++)
         {
             matrix[i,j] = new Random().Next(1,9);
         }
     }
     return matrix;
 }

 void PrintMatrix(int[,] matrix)
 {
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write($"{matrix[i,j]} ");
         }
         Console.WriteLine();
     }
 }

 int [] CountSumInRows(int[,] matrix)
 {
     int [] sumInLinesResults = new int[matrix.GetLength(0)];
     int sum = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             sum += matrix[i,j];
         }
         sumInLinesResults[i] = sum;
         sum = 0;
     }
     return sumInLinesResults;
 }

 void PrintSumInRows(int[] array)
 {
     for (int i = 0; i < array.Length; i ++)
     {
         Console.Write($"{i+1} - {array[i]} ");
     }
 }

 int GetMinRowsSum(int[] array)
 {
     int min = array[0];
     int result = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i] < min)

         { min = array[i];
           result = i;
         }
     }
     return result;
 }