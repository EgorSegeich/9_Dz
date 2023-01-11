/*
Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int BringOutNumbers(int X)
{
    if (X == 0) return 1;
    else
    {
        Console.Write(X + " ");
        return BringOutNumbers(X - 1);
    }
}

Console.Write("введите N = ");

int N = BringOutNumbers(Convert.ToInt32(Console.ReadLine()));
