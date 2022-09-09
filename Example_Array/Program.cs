int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; // size = 5, array = [0,0,0,0,0]
    for (int i = 0; i < array.Length; i++) // array.Length = size
    {
        array[i] = new Random().Next(2); // Next(5) => от 0 до 4
    }
    return array;
}
int[] resultArray = GetBinaryArray(8);

// Конвертируем массив в строчку

Console.WriteLine($"Result array: [ {String.Join("; ", resultArray)} ]");