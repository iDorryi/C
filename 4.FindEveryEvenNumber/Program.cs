//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
Console.WriteLine("введите число: ");
N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 1;
int znach = 0;
int Chetnie = (N / 2);

    while (i < Chetnie)
    {
        znach = znach + 2;
        Console.Write(znach);
        Console.Write(", ");
        i = i + 1;
    }
    count = count + 1;
    Console.WriteLine();