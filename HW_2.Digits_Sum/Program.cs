Console.WriteLine(Sum(4341));
 
int Sum(int D)
{
int result = 0;
result = result + D % 10;// result = result (0)+ 4341%10= 1 , 4
D = D / 10; // D = D (4341) /10 = 434, 43
if(D > 0)
 {
  result = result + Sum(D); 
 }
return result;
}



