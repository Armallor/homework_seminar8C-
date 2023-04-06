// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int firstRows = vvod("Введите количество строк первой матрицы: ");

int firstColumns = vvod("Введите количество столбцов первой матрицы: ");

int secondRows = vvod("Введите количество строк второй матрицы: ");

int secondColumns = vvod("Введите количество столбцов второй матрицы: ");

if (firstColumns != secondRows) Console.WriteLine("Данные матрицы перемножить нельзя");
else{

int[,] firstDualMassiv = GetArray(firstRows, firstColumns, 2, 4);

int[,] secondDualMassiv = GetArray(secondRows, secondColumns, 2, 4);

PrintArray(firstDualMassiv);

Console.WriteLine();

PrintArray(secondDualMassiv);

Console.WriteLine();

PrintArray(ProductOfArrays(firstDualMassiv, secondDualMassiv));
}

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

// Произведение двумерных массивов

int[,] ProductOfArrays(int[,] array, int[,] secondArray)
{
  int[,] newarray = new int[array.GetLength(0), secondArray.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          newarray[i, j] = 0;
          for (int n = 0; n < array.GetLength(0); n++)
          {
            newarray[i, j] += (array[i, n] * secondArray[n, j]);
          }
        }
    }
  return newarray;
}

int vvod (string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}