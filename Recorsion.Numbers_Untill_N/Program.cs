Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
string NumbersUntillN ( int start, int end)
{
    if(start == end)
    return start.ToString();
    return (start + "," + NumbersUntillN(start + 1, end ));
}
Console.WriteLine($"Номера до N это: {NumbersUntillN (1, N)}");