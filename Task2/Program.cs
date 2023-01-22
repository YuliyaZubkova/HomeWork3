/* Напишите программу, которая по заданному номеру четверти выводит
 диапазон возможных координат точек (X, Y) в этой четверти


     2   |    1
         |
------------------->
     3   |    4
         |
*/

// функция получения номера четверти с консоли
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result <= 4)
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Введите корректное число от 1 до 4.");
        }
    }
    return result;
}

// получение диапазона координат точек, которые могут лежать в заданной четверти
string GetDiapazon(int quarter)
{
    if(quarter == 1)
        return "Возможный диапазон координат X и Y от 0 до + бесконечности";
    else if(quarter == 2)
        return "Возможный диапазон координат X от 0 до - бесконечности, Y от 0 до + бесконечности";
    else if(quarter == 3)
        return "Возможный диапазон координат X от 0 до - бесконечности, Y от 0 до - бесконечности";
    else
        return "Возможный диапазон координат X от 0 до + бесконечности, Y от 0 до - бесконечности";
}

int quarter = GetNumber("Введите номер четверти ");

string diapazon = GetDiapazon(quarter);

Console.WriteLine($"Точка из четверти ({quarter}) имеет координаты в следующем диапазоне ({diapazon})");


