/*Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Summ(int M, int N)
{
    if (M == N) return N;
    return M + Summ(M + 1, N);
};

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (M > N) Console.WriteLine(Summ(N, M));
else if (N > M) Console.WriteLine(Summ(M, N));