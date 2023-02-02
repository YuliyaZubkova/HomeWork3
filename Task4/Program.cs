// Программа принимает число N и выдает на выходе таблицу квадратов от 1 до N


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }
    }
    return result;
}

void GetSquare(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i}, ");
    }
}

int n = GetNumber("Введите число N: ");

GetSquare(n);