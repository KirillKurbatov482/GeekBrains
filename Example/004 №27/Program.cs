﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine($"Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberA = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberA){
    
    int count = Convert.ToString(numberA).Length;
    int a = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      a = numberA - numberA % 10;
      result = result + (numberA - a);
      numberA = numberA / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberA);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

