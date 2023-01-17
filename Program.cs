Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    while (N >= 2)
    {
        if (N > 0 && N % 2 == 0)
        {
            Console.WriteLine(N);
            N = N - 1;
        }
        else
        {
            N = N - 1;
        }
    }
}
else if (N < 0)
{
    while (N <= -2)
    {
        if (N < 0 && N % 2 == 0)
        {
            Console.WriteLine(N);
            N = N + 1;
        }
        else
        {
            N = N + 1;
        }
    }
}
else if (N == 0)
{ Console.WriteLine("Введено нулевое значение"); }
