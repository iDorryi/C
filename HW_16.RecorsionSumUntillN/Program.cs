int Input(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int start = Input("Введите число M:");
int end = Input("Введите число N:");

int SumUntillN(int start, int end, int sum)
{
    if (start == end) return sum + start;
    else return SumUntillN(start + 1, end, sum + start);
}

if (start <= end)
{
    Console.WriteLine(SumUntillN(start, end, 0));
}
else
{
    Console.WriteLine(SumUntillN(end, start, 0));
}