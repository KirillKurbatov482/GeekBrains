int number = new Random().Next(1, 8);
Console.WriteLine (number);
if (number > 6)
Console.WriteLine($"Является выходным");
else 
Console.WriteLine($"Не является выходным");