// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите по порядку значения для заполнения массива");

int[,] dualmassiv = GetArray(4, 4);

PrintArray(dualmassiv);

// Заполнение массива спирально
int[,] GetArray(int m, int n)
{
    int[,] res = new int[m, n];
    for (int j = 0; j < n; j++)
    {
      res[0, j] = int.Parse(Console.ReadLine()!);
    }

    for (int i = 1; i < m; i++)
    {
      res[i, n - 1] = int.Parse(Console.ReadLine()!);
    }

    for (int j = n - 2; j >= 0; j--)
    {
      res[m - 1, j] = int.Parse(Console.ReadLine()!);
    }

    for (int i = m - 2; i >= 1; i--)
    {
      res[i, 0] = int.Parse(Console.ReadLine()!);
    }

    for (int j = 1; j < n - 1; j++)
    {
      res[1, j] = int.Parse(Console.ReadLine()!);
    }

    for (int j = 2; j >= 1; j--)
    {
      res[2, j] = int.Parse(Console.ReadLine()!);
    }    
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
