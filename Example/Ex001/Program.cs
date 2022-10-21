// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
string threeDigitNumberStr = Console.ReadLine();
string stringNumberStr = Convert.ToString(threeDigitNumberStr);
Console.WriteLine("Вторая цифра числа "+stringNumberStr[1]);