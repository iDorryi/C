int Factorial(int N)
{
    if (N == 1) 
    return 1; // Факториал от 1 это 1;
    return (N * Factorial (N-1));
}
Console.WriteLine(Factorial(3));