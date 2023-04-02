int x1 = numbers ("x1");
int y1 = numbers ("y1");
int z1 = numbers ("z1");
int x2 = numbers ("x2");
int y2 = numbers ("y2");
int z2 = numbers ("z2");
System.Console.WriteLine($"Расстояние равно {longe(x1, y1, z1, x2, y2, z2)}");

int numbers (string x)
{
    System.Console.WriteLine($"Введите значение {x}");
    int X = int.Parse(Console.ReadLine());
    return X;
}

double longe (int x1, int y1, int z1,int x2,int y2,int z2)
{
double longe = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)), 2);
return longe;
}