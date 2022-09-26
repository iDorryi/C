Console.WriteLine("Задайте двумерный массив размером mxn, заполненный случайными вещественными числами:");
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetMatrix (int m, int n)
{
  double[,] matrix = new double[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)  
  {
    for ( int j = 0; j < n; j++ )
    {
        matrix[i,j] = new Random().NextDouble() * 10;
    }
  }
  return matrix;
}
void PrintMatrix(double[,] inputmatrix)
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
double [,] resultMatrix = GetMatrix(rows, columns);
PrintMatrix(resultMatrix);
