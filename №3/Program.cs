int number()
{
    Console.Write($"Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = number();
cubs(N);


void cubs (int N)
{
    for (int i=1; i<=N; i++)
    {
     System.Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}");
    }
}
