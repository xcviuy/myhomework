// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] RealNumbers = new double[5];
  for (int i = 0; i < RealNumbers.Length; i++ )
  {
    RealNumbers[i] = new Random().Next(1, 10);
    Console.Write(RealNumbers[i] + " ");
  }

double max = RealNumbers[0];
double min = RealNumbers[0];

for (int i = 1; i < RealNumbers.Length; i++)
{
    if (max <= RealNumbers[i]) 
    {
        max = RealNumbers[i];
    }  
    if (min >= RealNumbers[i])
    {
        min = RealNumbers[i];
    }
}
double answer = max - min;
Console.WriteLine();
Console.WriteLine($"максимальое число {max}, минимльное {min}, разница: {answer}");
