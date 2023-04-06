// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] dualmassiv = GetArray(rows, columns, 11, 20);

PrintArray(dualmassiv);

Console.WriteLine();

SpecPrintArray(Total(dualmassiv));

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

// Вывод массива с указателями

void SpecPrintArray(int[,] array)
{
  int j = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write($"{array[i, j]} повторяется {array[i, j + 1]} раз");
    Console.WriteLine();
  }
}

// Счетчик
int[,] Total(int[,] array)
{
  int[,] newarray = new int[array.GetLength(0) * array.GetLength(1), 2];
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          int temp = array[i, j];
          int count = 1;
          for (int m = 0; m < array.GetLength(0); m++)
          {
            for (int l = 0; l < array.GetLength(1); l++)
            {
              if (temp == array[m, l]) count++;
            }
          }
          newarray[i * array.GetLength(1) + j, 0] = temp;
          newarray[i * array.GetLength(1) + j, 1] = count;
        }
    }
  return newarray;
}

int[,] Totalizer(int[,] array)
{
  znach[0, 0] = array[0, 0];
  for (int i = 1; i < array.GetLength(0); i++)
  {
    for (int j = 1; j < array.GetLength(0); j++)
    if (array[i, 0] == array[j, 0]) continue;
    
  }
}