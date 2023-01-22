// Программа принимает число N и выдает на выходе таблицу квадратов от 1 до N


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
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

int N = GetNumber("Введите число N: ");

    for (int i = 1; i < N; i++)
    {
        Console.Write($"{i*i}, ");
    }

