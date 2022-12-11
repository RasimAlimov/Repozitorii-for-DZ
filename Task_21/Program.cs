// Программа принимает координаты двух точек и находит расстояние между ними в 3д пространстве

Console.WriteLine("Введите координаты X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceXYZ (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return result;
}

Console.WriteLine ($"Расстояние между точками - {DistanceXYZ(x1, y1, z1, x2, y2, z2)}");