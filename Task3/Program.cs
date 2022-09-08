/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(n,m) = 29*/

Console.Write("Введите m: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите n: ");
uint n = Convert.ToUInt32(Console.ReadLine());

static uint Akk(uint n, uint m)
{
    if (n == 0)
    return m + 1;
    else if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.Write($" A (n, m) = {Akk(n, m)}");

