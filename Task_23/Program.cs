// // Программа принимает число N и выдает таблицу кубов от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<= number; i++)
{
    Console.WriteLine ($"{i*i*i}");
}
