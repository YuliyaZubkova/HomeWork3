// Напишите программу которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2Д пространстве


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

int x1 = GetNumber("Введите координату первой точки Х1: ");
int y1 = GetNumber("Введите координату первой точки Y1: ");
int x2 = GetNumber("Введите координату второй точки Х2: ");
int y2 = GetNumber("Введите координату второй точки Y2: ");

double sum1 = Math.Pow((x2-x1), 2);
double sum2 = Math.Pow((y2-y1), 2);

double result = Math.Sqrt(sum1+sum2);

Console.WriteLine($"Расстояние между двумя точками равно {result.ToString("#.00")}.");
