int[,] GetMatrix (int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)  
  {
    for ( int j = 0; j < n; j++ )
    {
        matrix[i,j] = new Random().Next(0,15);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] inputmatrix)
{
    for (int i = 0; i < inputmatrix.GetLength(0); i++)
    {
       for (int j = 0; j < inputmatrix.GetLength(1); j++)
       {
        Console.Write(inputmatrix[i,j] + "\t");
       }
       Console.WriteLine();
    }
    
}
int [,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);

int[] FindArray(int[,] resultMatrix, int row, int col)
{
    int[] Finalresult = new int[2];
    if (row >= resultMatrix.GetLength(0) || col >= resultMatrix.GetLength(1))
    {
     return new int[] {-1, 0};
    }
    else 
    {
        return new int[] {1, resultMatrix[row,col] };
    }
}
 int[] res = FindArray(resultMatrix, 1, 2);
 Console.WriteLine(res[0]);
 if (res[0] == -1)
 {
 Console.WriteLine("Элемента нет");
 }
 else 
 {
  Console.WriteLine("Элемент есть");  
  Console.WriteLine(res[1]);
 }
