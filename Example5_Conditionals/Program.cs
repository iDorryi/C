Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "катя")
{
    Console.WriteLine("ДА ЭТО ЖЕ КАТЯ!!!");
}
else 
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}