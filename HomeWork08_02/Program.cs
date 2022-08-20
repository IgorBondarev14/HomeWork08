// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] sum = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        sum[i] += array[i, j];
}
Console.Write("Сумма элементов по строкам равна: ");
Console.WriteLine("[" + string.Join(", ", sum) + "]");
int min_index = 0;
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (sum[i] < sum[j]) 
            min_index = i + 1;
    }
}
Console.WriteLine("Наименьшая сумма элементов в строке № " + min_index);
