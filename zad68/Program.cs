int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число, либо оно отрицательное. \nВведите число ещё раз: ");
        }
    }
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите два положительных числа: M и N.");
Console.Write("Введите число M: ");
int m = InNumber();
Console.Write("Введите число N: ");
int n = InNumber();
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
