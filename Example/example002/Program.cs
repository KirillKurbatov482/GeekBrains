Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > -100 && number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    while (number <= -1000 || number >= 1000)
    {
        number /= 10;
    }
    int secondnumber = number %10;
    Console.WriteLine($"Третья цифра числа -> {secondnumber}");
}



