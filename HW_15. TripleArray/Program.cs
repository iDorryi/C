Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента, массив размеры 2х2х2:");


 int[,,] tripleArray = new int[2,2,2];
 tripleArray = InputIndex(tripleArray);
 PrintTripleArray(tripleArray);

 void PrintTripleArray (int[,,]threeSizeArray)
 {
     for (int i = 0; i < threeSizeArray.GetLength(0);i++)
     {
         for (int j = 0; j < threeSizeArray.GetLength(1);j++)
         {
             for (int k = 0; k < threeSizeArray.GetLength(2);k++)
             {
                 if (threeSizeArray[i,j,k] > 0)
                 {
                     Console.Write($" {threeSizeArray[i,j,k]}({i},{j},{k}) ");
                 }
                 else
                 {
                     Console.Write($"{threeSizeArray[i,j,k]}({i},{j},{k}) ");
                 }
             }
             Console.WriteLine();
         }
     }
 }

 bool CheckIndex (int[,,] threeSizeArray, int num)
 {
     for (int i = 0; i < threeSizeArray.GetLength(0);i++)
     {
         for (int j = 0; j < threeSizeArray.GetLength(1);j++)
         {
             for (int k = 0; k < threeSizeArray.GetLength(2);k++)
             {
                 if (threeSizeArray[i,j,k] == num)
                 {
                     return false;
                 }
             }
         }
     }
     return true;
 }

 int [,,] InputIndex (int[,,]threeSizeArray)
 {
     for (int i = 0; i < threeSizeArray.GetLength(0);i++)
     {
         for (int j = 0; j < threeSizeArray.GetLength(1);j++)
         {
             for (int k = 0; k < threeSizeArray.GetLength(2);k++)
             {
                 threeSizeArray[i,j,k] = CreateIndex(threeSizeArray);
             }
         }
     }
     return threeSizeArray;
 }

 int CreateIndex (int [,,] threeSizeArray)
 {
     Random rnd = new Random();
     int input = rnd.Next(1, 3)==1 ? rnd.Next(-99, 9) : rnd.Next(10,100);
     if (CheckIndex(threeSizeArray, input) != true)
     {
         CreateIndex(threeSizeArray);
     }
     return input;
 }