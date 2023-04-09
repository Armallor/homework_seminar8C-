// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] dualmassiv = GetArray(rows, columns, 11, 20);

PrintArray(dualmassiv);

Console.WriteLine();

int[] rowArray = GetRowArray(dualmassiv);

Console.WriteLine($"[{String.Join(",", rowArray)}]");

int[] sortedArray = SortArray(rowArray);

Console.WriteLine();

Console.WriteLine($"[{String.Join(",", sortedArray)}]");

PrintSortedArray (sortedArray);

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

// Преобразование двумерного массива в одномерный

int [] GetRowArray (int[,] array)
{
  int[] result = new int[array.GetLength(0) * array.GetLength(1)];
  int index = 0;
  for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        result[index] = array[i, j];
        index++;
      }
    }
  return result;
}

// Сортировка

int[] SortArray (int[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
      for (int j = i + 1; j < array.Length; j++)
      {
        if (array[i] > array[j])
          {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
          }
      }
    }
  return array;
}

// Вывод счетчика

void PrintSortedArray (int[] array)
{
  int el = array[0];
  int count = 1;
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] != el)
    {
      Console.WriteLine($"Элемент {el} встречается {count} раз");
      el = array[i];
      count = 1;
    }
    else count++;
  }
  Console.WriteLine($"Элемент {el} встречается {count} раз");
}