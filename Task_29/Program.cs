// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] InitArray (int dimension)

{
    int [] numbers = new int[8];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        numbers [i] = rnd.Next(0, 11);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"{numbers[i]} ");
    }
}