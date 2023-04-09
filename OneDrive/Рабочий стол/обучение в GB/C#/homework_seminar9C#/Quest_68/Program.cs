// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.

Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
if (M < 0 || N < 0) Console.WriteLine("Функция Аккермана не определяется в заданных пределах чисел");
else Console.WriteLine($"Функция Аккермана чисел ({M}, {N}) равна {Akkerman(M, N)}");
int Akkerman(int m, int n)
  {
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
  }