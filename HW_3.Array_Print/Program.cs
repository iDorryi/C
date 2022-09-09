int [] array = {1, 3, 5, 2, 7, 19, 4};
void PrintArray(int[] array)
{
    int l = array.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
PrintArray(array);