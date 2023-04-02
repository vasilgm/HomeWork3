int N = number();
if (N >=10000 && N<=99999)
{
    if(polindrom(N)) System.Console.WriteLine($"Число {N} является полиндромом");
    else System.Console.WriteLine($"Число {N} не является полиндромом");
}
else System.Console.WriteLine($"Число {N} не пятизначное");

int number ()
{
    System.Console.WriteLine("Введите число N:");
    int N = int.Parse(Console.ReadLine());
    return N;
}

bool polindrom (int N)
{
    int N1 = N / 10000;
    int N2 = N % 10;
    int N3 = N / 1000 % 10;
    int N4 = N / 10 % 10;
    return N1 == N2 || N3 == N4;
}