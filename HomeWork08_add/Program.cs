// Задача 61(ДОП). Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольник

Console.Write("Введите выводимое число строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Pascal = new int[n, n * 2 + 1];
Pascal[0, n] = 1;
Pascal[1, n + 1] = 1;
Pascal[1, n - 1] = 1;
for (int i = 2; i < Pascal.GetLength(0); i++)
{
    for (int j = 0; j < Pascal.GetLength(1); j++)
    {
        if (i % 2 == 0)
        {
            if (j == 0 || j % 2 != 0 || j == n * 2)
                Pascal[i, j] = 0;
            else
            {
                if (j < n - i)
                    Pascal[i, j] = 0;
                else
                    Pascal[i, j] = Pascal[i - 1, j - 1] + Pascal[i - 1, j + 1]; 
            }
        }
        else
        {
            if (j == 0 || j % 2 == 0 || j == n * 2)
                Pascal[i, j] = 0;
            else
                Pascal[i, j] = Pascal[i - 1, j - 1] + Pascal[i - 1, j + 1]; 
        }       
    }
}

for (int i = 0; i < Pascal.GetLength(0); i++)
{
    for (int j = 0; j < Pascal.GetLength(1); j++)
    {
        if (Pascal[i, j] == 0)
            Console.Write(" ");
        else
            Console.Write($"{Pascal[i, j]}" + " ");    
    }
    Console.WriteLine();
}
Console.WriteLine();
