// Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива:");

// //Функция для создания двумерного массива с вводом значений строк и столбцов с клавиатуры и заполнением случайными числами от 0 до 10.
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("А теперь введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] FillMatrix (int k, int l)
// {
//  int[,] matrix = new int[k, l];
//  for (int i = 0; i < k; i++)
//  {
//     for (int j = 0; j < l; j++)
//     {
//         matrix[i,j] = new Random().Next(0, 11);
//     }
//  }
//  return matrix;
// }


// void PrintMatrix(int[,] outmatrix)
// {
//     for ( int m = 0; m < outmatrix.GetLength(0); m++)
//     {
//       for ( int n = 0; n < outmatrix.GetLength(1); n++)
//         {
//           Console.Write(outmatrix[m,n] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int [,] PrintedMatrix = FillMatrix(rows, columns);
// PrintMatrix(PrintedMatrix);

// int[,] SortedArray (int[,] PrintedMatrix)
//  {
//      for(int i = 0; i < PrintedMatrix.GetLength(0); i++)
//      {
//          for (int count = 0; count < PrintedMatrix.GetLength(1); count++)
//          {
//              for (int j = 1; j < PrintedMatrix.GetLength(0); j++)
//              {
//                  if (PrintedMatrix[i,j-1] < PrintedMatrix[i,j])
//                  {
//                      int temp = PrintedMatrix[i,j];
//                      PrintedMatrix[i,j] = PrintedMatrix[i,j-1];
//                      PrintedMatrix[i,j-1] = temp;
//                      j = 1;
//                  } 
//              }
//          }
//      }
//      return PrintedMatrix;
//  }

//  void PrintSortedArray(int[,] PrintedMatrix)
//  {
//      for(int i = 0; i < PrintedMatrix.GetLength(0); i++)
//      {
//          for (int j = 0; j < PrintedMatrix.GetLength(1); j++)
//          {
//              Console.Write($"{PrintedMatrix[i,j]} ");
//          }
//          Console.WriteLine();
//      }
//  }


int columnArray = Read("Введите количество столбцов: ");
int rowArray = Read("Введите количество строк: ");

 int[,] matrix = new int[rowArray, columnArray];
 FillArrayRandom(matrix);
 PrintArray(matrix);
 Console.WriteLine();
 int[,] matrixSort = SortArray(matrix);
 PrintArray(matrixSort);

 int[,] SortArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         int temp;
         for (int j = 0; j < array.GetLength(1) - 1; j++)
         {
             for (int b = j + 1; b < array.GetLength(1); b++)
             {
                 if (array[i, j] > array[i, b])
                 {
                     temp = array[i, j];
                     array[i, j] = array[i, b];
                     array[i, b] = temp;
                 }
             }
         }

     }
     return matrix;
 }

 int Read (string message)
 {
     Console.Write(message);
     return Convert.ToInt32(Console.ReadLine()!);
 }

 void FillArrayRandom (int[,] array)
 {
     Random rand = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = rand.Next(1, 10);
         }
     }
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

   
