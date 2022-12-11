// Программа принимает на вход пятизначное число и проверяет является оно палиндромом или нет

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
    if ((number[0] == number[4]) && (number[1] == number[3]))
    Console.WriteLine("Введенное число является палиндромом");
    else Console.WriteLine("Введенное число НЕ является палиндромом");

else Console.WriteLine("Введите пятизначное число");

