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

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

Console.Write("Введите число M: ");
int m = InNumber();
Console.Write("Введите число N: ");
int n = InNumber();
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");
