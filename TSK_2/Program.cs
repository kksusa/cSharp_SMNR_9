int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
        if (int.TryParse(Console.ReadLine()!, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

long SumFromMtoN (int m, int n)
{
    if (m == n) return n;
    return m + SumFromMtoN(m + 1, n);
}

int m = CheckNumbers("Введите начальное число:");
int n = CheckNumbers("Введите конечное число:");
Console.Write($"Сумма диапазона между числами равна {SumFromMtoN(m, n)}.");