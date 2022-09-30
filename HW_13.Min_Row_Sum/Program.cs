Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов:");
// 1. Get the Matrix with the same lenght for every column and row;
// 2. Fill it
// 3. Print the Matrix
// 4. Create the input method. Let it be called "Input"
// 5. Find the summ in every row in another method;
// 6. Find and output the row with the least summ.
int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
 int Input (string message)
 {
     Console.Write(message);
     return Convert.ToInt32(Console.ReadLine()!);
 }

 int [,] FillArray (int[,] array)
 {
     Random rand = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = rand.Next(1, 11);
         }
     }
     return array;
 }

 void PrintArray (int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write(array[i, j] + " ");
         }
         Console.WriteLine();
     }
 }

int[,] matrix = new int[rows, columns];
int[,] ResultArray = FillArray(matrix);
 PrintArray(ResultArray);
   