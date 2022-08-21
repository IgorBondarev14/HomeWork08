<<<<<<< HEAD
﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. 
//Напишите программу, которая будет построчно выводить массив добавляя индексы каждого элемента.

=======
﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. Напишите программу, 
// которая будет построчно выводить массив добавляя индексы каждого элемента.
>>>>>>> c1c0ba9ca3096a0d975041bfdf9a05306c57aaaa

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество полос: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] check = new int[n * m * l];
for (int i = 0; i < check.GetLength(0);i++)
{
    int number = new Random().Next(10, 100);
    if (i != 0)
    {
        for (int j = 0; j < i; j++)
        {
            if (number == check[j])
                number = new Random().Next(10, 100);
            else
               check[i] = number; 
        }
    }
    else
        check[i] = number;
}

int[,,] array = new int[n, m, l];
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < l; k++)
        {
           array[i, j, k] = check[count];
           Console.Write($"{array[i, j, k]}" + "(" + i + ", " + j + ", " + k + ")" + "\t");
           count++;
        }
        Console.WriteLine();
    }
}

