// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int result = Convert.ToInt32(Console.ReadLine());

int number1 = result % 100; // 782 / 10 = 78
int number2 = number1 / 10; // 782 % 10 

Console.WriteLine("Вторая цифра числа: " + number2);
