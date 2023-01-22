/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
Формула - AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

int x1 = GetNumber("Введите координату первой точки Х1: ");
int y1 = GetNumber("Введите координату первой точки Y1: ");
int z1 = GetNumber("Введите координату первой точки Z1: ");
int x2 = GetNumber("Введите координату второй точки Х2: ");
int y2 = GetNumber("Введите координату второй точки Y2: ");
int z2 = GetNumber("Введите координату второй точки Z2: ");

double sum1 = Math.Pow((x2-x1), 2);
double sum2 = Math.Pow((y2-y1), 2);
double sum3 = Math.Pow((z2-z1), 2);

double result = Math.Sqrt(sum1+sum2+sum3);

Console.WriteLine($"Расстояние между двумя точками равно {result.ToString("#.00")}.");

