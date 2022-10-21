// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите любое число, обозначающее день недели");
string AnyDayStr = Console.ReadLine();
int stringAnyDayStr = Convert.ToInt32(AnyDayStr);

void CheckTheDayWeek (int stringAnyDayStr) 
{
    if (stringAnyDayStr == 6 || stringAnyDayStr == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else if (stringAnyDayStr < 1 || stringAnyDayStr > 7) 
    {
        Console.WriteLine("Не является днем недели");
    }
    else Console.WriteLine("Этот день не выходной");   
    }
CheckTheDayWeek (stringAnyDayStr); 