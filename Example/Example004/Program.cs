// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.Clear();
// Console.Write("Введите число A: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write("Введите число B: ");
// int C = int.Parse(Console.ReadLine());

// int number = N;

// for (int i = 1; i < C; i++)
// {
// number = number * N;
// }
// Console.WriteLine("A в степени B равно: " + number);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine($"Выдаёт сумму цифр в числе");
// Console.Write("Введите число N: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberA){
    
//     int count = Convert.ToString(numberA).Length;
//     int a = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++){
//       a = numberA - numberA % 10;
//       result = result + (numberA - a);
//       numberA = numberA / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberA);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] array = GetIntArray(8);
// Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


// int[] GetIntArray(int size)
// {
// int[] result = new int[size];
// for (int i = 0; i < size; i++)
// {
// result[i] = new Random().Next(-100000, 120000);
// }

// return result;
// }