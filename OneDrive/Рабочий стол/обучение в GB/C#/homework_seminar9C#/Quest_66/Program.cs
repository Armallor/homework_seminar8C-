// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine()!);

if (M > N) Console.WriteLine(PrintSum(N, M));
else Console.WriteLine(PrintSum(M, N));

// Метод
int PrintSum(int start, int end){
    if (start == end) return start;
    return (PrintSum(start + 1, end) + start);
}