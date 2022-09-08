/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.Write("Введите m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int m = Convert.ToInt32(Console.ReadLine());

void ShowNum(int n, int m)
{
    if (m != n)
    {
        ShowNum(n, m-1);
    }
Console.Write(m + " ");
}
Console.WriteLine("Все натуральные числа в промежутке от M до N:");
ShowNum(n, m);