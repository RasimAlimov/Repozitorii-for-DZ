// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
int numberb1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1: ");
int numberk1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2: ");
int numberb2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2: ");
int numberk2= Convert.ToInt32(Console.ReadLine());

int x = (numberb2 - numberb1) / (numberk1 - numberk2);
int y = numberk1 * x + numberb1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

