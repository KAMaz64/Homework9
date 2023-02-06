/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

ResultingFunction(M, N);

void ResultingFunction(int m, int n)
{
    Console.Write(SumMToN(m - 1, n));
}

int SumMToN(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumMToN(m, n);
        return sum;
    }
}
