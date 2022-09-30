int rows = Get("Введите количество строк: ");
int columns = Get("Введите количество столбцов: ");
 int Get(string message)
 {
     Console.Write(message);
     return Convert.ToInt32(Console.ReadLine()!);
 }

 int[,] matrix = new int[rows, columns];
 FillArray(matrix);
 PrintArray(matrix);
 Console.WriteLine();
 

 int[,] SortArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         int temp;
         for (int j = 0; j < array.GetLength(1) - 1; j++)
         {
             for (int a = j + 1; a < array.GetLength(1); a++)
             {
                 if (array[i, j] > array[i, a])
                 {
                     temp = array[i, j];
                     array[i, j] = array[i, a];
                     array[i, a] = temp;
                 }
             }
         }

     }
     return matrix;
 }


 void FillArray (int[,] array)
 {
     Random rand = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = rand.Next(1, 11);
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
int[,] matrixSort = SortArray(matrix);
 PrintArray(matrixSort);
   
