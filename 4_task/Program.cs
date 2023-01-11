/*
Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int [,] array = new int[4,4];

int x = 1;
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = x;
        x++;
    }
}

x = 5;
for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 3; j < array.GetLength(1); j++)
    {
        array[i,j] = x;
        x++;
    }
}

x = 10;
for (int i = 3; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = x;
        x--;
    }
}

x = 12;
for (int i = 1; i < 3; i++)
{
    for (int j = 0; j < 1; j++)
    {
        array[i,j] = x;
        x--;
    }
}

x = 13;
for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < 3; j++)
    {
        array[i,j] = x;
        x++;
    }
}

x = 16;
for (int i = 2; i < 3; i++)
{
    for (int j = 1; j < 3; j++)
    {
        array[i,j] = x;
        x--;
    }
}




//печать массива
for (int q = 0; q < array.GetLength(0); q++)
{
    for (int w = 0; w < array.GetLength(1); w++)
    {
        if (array[q, w] < 10)
        {
            Console.Write("0" + array[q, w] +  " ");
        }
        else
        {
            Console.Write(array[q, w] +  " ");    
        }    
    }
    Console.WriteLine();
}