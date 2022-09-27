Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет:");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix (int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)  
  {
    for ( int j = 0; j < n; j++ )
    {
        matrix[i,j] = new Random().Next(1,10);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] inputmatrix)
{
    for (int i = 0; i < inputmatrix.GetLength(0); i++)
    {
       for (int m = 0; m < inputmatrix.GetLength(1); m++)
       {
        Console.Write(inputmatrix[i,m] + "\t");
       }
       Console.WriteLine();
    }
    
}
int [,] resultMatrix = GetMatrix(rows, columns);
PrintMatrix(resultMatrix);



Console.WriteLine("Введите индексы матрицы: ");
int rowsIndex = Convert.ToInt32(Console.ReadLine());
int columnsIndex = Convert.ToInt32(Console.ReadLine());
if (rowsIndex >= rows && columnsIndex >= columns)
{
    Console.WriteLine("Нет такого числа");
}
else 
{ 
    object c = resultMatrix.GetValue(rowsIndex, columnsIndex);
    Console.WriteLine($"Такое число есть: {c}");
}
Console.WriteLine();