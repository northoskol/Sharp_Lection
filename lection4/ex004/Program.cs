//ФИБОННАЧИ

//  f(1)=1
// f(2)=1
// f(n)=F(n-1)+f(n-2)

double Fibo(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibo(n - 1) + Fibo(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fibo(i)}");
}