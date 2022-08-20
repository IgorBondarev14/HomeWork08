// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первая матрица:");
int[,] array1 = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array1[i, j] = new Random().Next(1, 10);
        Console.Write($"{array1[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
int[,] array2 = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array2[i, j] = new Random().Next(1, 10);
        Console.Write($"{array2[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Матрица произведения:");
int[,] array_composition = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array_composition[i, j] = array1[i, j] * array2[i, j];
        Console.Write($"{array_composition[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
