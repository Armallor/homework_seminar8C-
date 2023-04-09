// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

// Метод
string PrintNumbers(int start, int end){
    if(start==end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}