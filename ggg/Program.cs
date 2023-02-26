/*
void NumbersN(int N)
{
    Console.Write(N+" ");
    if(N>1)  NumbersN(N-1);
}

Console.Write(" Введите N : ");
int uSnum= Convert.ToInt32(Console.ReadLine());

NumbersN(uSnum);
*/
/*
int NumbersN(int M, int N,int res)
{
    if (N+1>M) 
    {
         res+=M;
         return NumbersN(M+1,N,res); 
    }
    else 
         return res;
}

Console.Write(" Введите M : ");
int uSnumM= Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите M : ");
int uSnumN= Convert.ToInt32(Console.ReadLine());
int res=0;
if(uSnumM<uSnumN)
{
int resNew = NumbersN(uSnumM,uSnumN,res);
Console.Write(resNew);
}
else
Console.Write("error");
*/
static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

uint res=A(3,2);
Console.WriteLine(res);
