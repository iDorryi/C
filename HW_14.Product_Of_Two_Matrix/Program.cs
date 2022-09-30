Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц: ");


 int a = new Random().Next(3,4);
 int b = new Random().Next(3,4);
 int c = new Random().Next(3,4);

 int[,] firstMatrix = new int[a,b];
 firstMatrix = FillArray(firstMatrix);
 PrintArray(firstMatrix);
 Console.WriteLine();

 int[,] secondMatrix = new int[b,c];
 secondMatrix = FillArray(secondMatrix);
 PrintArray(secondMatrix);
 Console.WriteLine();

 int [,] result = CountResult(firstMatrix, secondMatrix);
 PrintArray(result);


 int[,] FillArray (int[,] matrix)
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

 int[,] CountResult (int [,] firstTable, int[,] secondTable)
 {
     int[,] resultTable = new int[firstTable.GetLength(0),secondTable.GetLength(1)];
     for (int i = 0; i < firstTable.GetLength(0); i ++)
     {
         for (int j = 0; j < secondTable.GetLength(1); j++)
         {
             resultTable[i,j] = 0;
             for (int k = 0; k < firstTable.GetLength(0); k++)
             {
                 resultTable[i,j] = resultTable[i,j] + firstTable[i,k] * secondTable[k,j];
             }
         }
     }
     return resultTable;
 }

 void PrintArray (int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write($"{array[i,j]} ");
         }
         Console.WriteLine();
     }
 }
