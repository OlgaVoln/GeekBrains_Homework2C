
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int thirdDigit = GetThirdDigit(number);

if (thirdDigit == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}


static int GetThirdDigit(int number)
{
    if (number < 100)
    {
        // Число меньше трехзначного
        return -1;
    }

    int thirdDigit = (number / 100) % 10;
    return thirdDigit;
}



