Console.WriteLine(Sum(42414));
 
int Sum(int value)
{
int result = 0;
result += value % 10;
value /= 10;
if(value > 0)
 {
  result += Sum(value);
 }
return result;
}
 


