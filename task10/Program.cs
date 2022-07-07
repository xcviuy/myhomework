// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = 1;

for (int i = 0; i < b; i++)
{
    pow *= a;
}

// double pow = Math.Pow(a,b);

Console.WriteLine("Число " + a + " в степени " + b + " равно " + pow);

