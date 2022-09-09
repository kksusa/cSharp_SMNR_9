int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param} ");
        if (int.TryParse(Console.ReadLine()!, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

int NumbersFromMtoN (int m, int n)
{
    Console.Write($"{m} ");
    if (m == n) return n;
    return NumbersFromMtoN(m + 1, n);
}
NumbersFromMtoN(CheckNumbers("Введите начальное число:"), CheckNumbers("Введите конечное число:"));