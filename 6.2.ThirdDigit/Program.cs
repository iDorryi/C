Console.Write("Введите число: ");
int AddedNumber = Convert.ToInt32(Console.ReadLine());
string StringNumber = Convert.ToString(AddedNumber);
if (StringNumber.Length > 2){
  Console.WriteLine("третья цифра - " + StringNumber[2]);
}
else {
  Console.WriteLine($"В числе {AddedNumber} - третьей цифры нет!");
}