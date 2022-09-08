/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Sum(m, n);

int Sum(int m, int n)
{
    if (n > m)
        return n + Sum(m, n - 1);
    return m;
}
Console.WriteLine($"Сумма чисел от {m} до {n} = {result}");