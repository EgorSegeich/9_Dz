/*
Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum = 0;

int SumOfElements(int X, int Y)
{
    if (Y > X)
    {
        sum = X + sum + SumOfElements(X + 1, Y);
        return sum;
    }
    else return Y;
}

Console.Write("введите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("введите N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма элементов: " + SumOfElements(M, N));
