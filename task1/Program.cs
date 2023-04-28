//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");

int digit = number / 10 % 10;
Console.WriteLine($"Вторая цифра этого числа: {digit}");