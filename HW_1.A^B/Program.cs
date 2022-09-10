// Console. WriteLine("Введите число  A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console. WriteLine("Введите число  B");
// int B = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(A, B);
// Console.WriteLine(result);



// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int aGrade = Grade(A, B);
// Console.WriteLine($"Число {A} в степени {B} = {aGrade}");
// int Grade(int A, int B)
// {
//   int result = 1;
//   for(int i = 1; i <= B; i++){
//     result = result * A;
//   }
//     return result;
// }

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
  for(int i = 1; i <= B; i++)
  {
    result = result * A;
  }
Console.WriteLine($"Число {A} в степени {B} = {result}");

