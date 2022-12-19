// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив
int [] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }
    return array;
}

// распечатать массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//найти сумму элементов на нечетных позициях в массиве
int FindSummOddNumbers(int[] array)
{
    int summ = 0;
    for (int i = 1;  i < array.Length; i=i+2)
    {
        summ = summ + array[i];
    }
    return summ;
}

int dimension = GetNumber("Введите размерность массива: ");
int[] array = InitArray(dimension);
PrintArray(array);
int summOddNumbers = FindSummOddNumbers(array);

Console.WriteLine($" Сумма элементов в массиве стоящих на нечетных позициях: {summOddNumbers}");