// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
string AnyNumberStr = Console.ReadLine();
string stringAnyNumberStr = Convert.ToString(AnyNumberStr);
if (AnyNumberStr.Length > 2) 
{
    Console.WriteLine("Третья цифра " + AnyNumberStr[2]);
}  
else 
{
    Console.WriteLine("Третьей цифры нет");
}