﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sum = 0;
    Console.Write(" ");

    for (int i = 0; i < randomNumbers.Length; i++ )
    {
        randomNumbers[i] = new Random().Next(min, max);
        Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 0)
        {
            sum += randomNumbers[i];
        }
    }
    return sum;
}

int randomNumbers =  RandomNumbers(numberElements, 1, 10);
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + randomNumbers);
