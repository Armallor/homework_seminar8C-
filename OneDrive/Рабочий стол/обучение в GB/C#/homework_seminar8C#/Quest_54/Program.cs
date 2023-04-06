// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] dualmassiv = GetArray(rows, columns, 11, 20);

PrintArray(dualmassiv);

Console.WriteLine();

PrintArray(DecreasingArrayElements(dualmassiv));

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
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

// Метод упорядочения по убыванию элементов каждой строки

int[,] DecreasingArrayElements(int[,] array)
{
  int[,] newarray = new int[array.GetLength(0),array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          int temp = array[i, j];
          int count = 0;
          int repeat = 0;
          for (int m = 0; m < array.GetLength(1); m++)
          {
            if (temp < array[i, m]) count++;
            if (temp == array[i, m]) repeat++;
          }
          newarray[i, count] = temp;
          for (int l = 1; l < repeat; l++)
          {
            newarray[i, count + l] = temp;
          }
        }
    }
  return newarray;
}