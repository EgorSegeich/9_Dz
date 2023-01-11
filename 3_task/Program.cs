/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?)
*/

Console.Write("введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return A(M - 1, 1); 
    if (M > 0 && N > 0) return A(M - 1, A(M, N - 1));
    else return 0;
}

Console.WriteLine(A(m, n));