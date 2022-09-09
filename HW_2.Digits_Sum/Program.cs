Console.WriteLine(Sum(4221431));
 
int Sum(int N)
{
int result = 0;
result += N % 10;
N /= 10;
if(N > 0)
 {
  result += Sum(N);
 }
return result;
}
 


