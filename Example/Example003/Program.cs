// // Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 3) + Math.Pow(y1-y2, 3));
// Console.WriteLine($"d={d:f3}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
// Console.Write($"{i*i} ");
// }

// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");