Console.Write("Введите номер дня недели: ");
int Date = Convert.ToInt32(Console.ReadLine());

if (Date > 5 && Date <= 7)
{
    Console.WriteLine($"{Date}-й день недели - это выходной");
}
else if ( Date < 6 && Date >=1 )
{
    Console.WriteLine($"{Date}-й день недели - это не выходной(");
}