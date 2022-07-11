﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];

void FillArray(int[] array)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int digitPositive(int[] array)
{
    int digit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            digit++;
        }
    }
    return digit;
}

FillArray(numbers);
PrintArray(numbers);
int digit = digitPositive(numbers);
Console.WriteLine("Количество чётных чисел в массиве: " + digit);


