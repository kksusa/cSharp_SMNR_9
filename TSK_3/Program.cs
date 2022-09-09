int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
        if (int.TryParse(Console.ReadLine()!, out int number) && number >= 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

long AckermannFunction(long m, long n)
{
    if (m == 0) return n + 1; 
    else if (m > 0 & n == 0) return AckermannFunction(m - 1, 1);
    else if (m > 0 & n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}

int m = CheckNumbers("Введите первое число:");
int n = CheckNumbers("Введите второе число:");
Console.Write($"Функция Аккермана равна {AckermannFunction(m, n)}.");