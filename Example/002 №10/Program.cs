int number = new Random().Next(100, 1000);
int secondnumber = number / 10;
int lastNum = secondnumber % 10;
Console.WriteLine(number);
Console.WriteLine(lastNum);