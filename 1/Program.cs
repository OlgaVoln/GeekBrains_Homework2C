//  Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число число");
int number = Convert.ToInt32(Console.ReadLine());
int Digit = number % 100;
int secondDigit = Digit / 10;
Console.WriteLine($"{number} -> {secondDigit}");
