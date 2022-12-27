// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
//int [,] numbers = new int [10,10];
//FillArrayRandomNumbers(numbers);

if (n > arr.GetLength(0) || m > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {arr[n-1,m-1]}");
}

