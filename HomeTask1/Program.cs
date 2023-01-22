/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/ 

// функция получения числа с консоли
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
            Console.WriteLine("Ввели не число или 0ю Введите корректное число.");
        }
    }
    return result;
}

int N = GetNumber("Введите пятизначное число: ");

Console.WriteLine(Count(N));
