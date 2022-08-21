// Задача 62. Заполните спирально массив 4 на 4.

Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];
int count = 1;
for (int k = 1; k < n + 1 / 2; k++)
{
    for (int i = k - 1; i < k; i++) // проход вправо
    {
        for (int j = k - 1; j < n; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = count;
                count++;
            }
            else
                j++;            
        }
    }
    for (int i = k; i < n; i++)    // проход вниз
    {
        for (int j = n - k; j <= n - k; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = count;
                count++;
            }
            else 
                i++;
        }
    }
    for (int i = n - k; i < n; i++) // проход влево
    {
        for (int j = n - k - 1; j >= 0; j--)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = count;
                count++;
            }
            else
                j--;
        }
    }
    for (int i = n - k - 1; i > 0; i--) // проход вверх
    {
        for (int j = k - 1; j < k; j++)
        {
            if (array[i,j] == 0)
            {
                array[i, j] = count;
                count++;
            }
            else
                i--;
        }
    }
}

for (int i = 0; i < n; i++) //печать реестра
{
    for (int j = 0; j < n; j++)
        Console.Write($"{array[i, j]}" + "\t");
    Console.WriteLine(); 
}

Console.WriteLine();      
 