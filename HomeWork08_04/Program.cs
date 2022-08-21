// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. Напишите программу, 
// которая будет построчно выводить массив добавляя индексы каждого элемента.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество полос: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array1 = new int[n, m, l];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < l; k++)
        {
            array1[i, j, k] = new Random().Next(10, 100);
            Console.Write($"{array1[i, j, k]}" + "(" + i + ", " + j + ", "+ k + ")" + "\t");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

