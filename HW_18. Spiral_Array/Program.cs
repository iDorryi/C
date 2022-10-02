Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4: ");

// int Input(string message)
// {
//     Console.Write(message);
//     int res = Convert.ToInt32(Console.ReadLine());
//     return res;
// }
//  int size = Input("Введите размер матрицы:");

 int[,] spiral = new int[4, 4];
 GetSpiral(spiral);
 PrintArray(spiral);

void GetSpiral(int[,] array)
 {
     int number = 0;
     int i = 0;
     int j = 0;

     while (number <= array.GetLength(0) * array.GetLength(1))
     {
         array[i, j] = number;
         if (i <= j + 1 && i + j < array.GetLength(1) - 1)
             j++;
         else if (i < j && i + j >= array.GetLength(0) - 1)
             i++;
         else if (i >= j && i + j > array.GetLength(1) - 1)
             j--;
         else
             i--;
         number++;
     }
 }

 void PrintArray(int[,] inArray)
 {
     for (int i = 0; i < inArray.GetLength(0); i++)
     {
         for (int j = 0; j < inArray.GetLength(1); j++)
         {
             Console.Write($"{inArray[i, j]} ");
         }
         Console.WriteLine();
     }
 }

 