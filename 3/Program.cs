// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
{
    bool isWeekend = (dayNumber == 6 || dayNumber == 7);

    if (isWeekend)
    {
        Console.WriteLine("Этот день является выходным.");
    }
    else
    {
        Console.WriteLine("Этот день не является выходным.");
    }
}
else
{
    Console.WriteLine("В неделе всего 7 дней.");
}





